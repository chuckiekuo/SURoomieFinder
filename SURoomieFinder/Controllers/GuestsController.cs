﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SURoomieFinder.Models;

namespace SURoomieFinder.Controllers
{
    public class GuestsController : Controller
    {
        private GuestDbContext db = new GuestDbContext();

        // GET: Guests
        public async Task<ActionResult> Index()
        {
            return View(await db.Guests.ToListAsync());
        }

        public async Task<ActionResult> ViewAnswers(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Guest guest = await db.Guests.FindAsync(id);
            Answers answers = new Answers();
            if (guest == null)
            {
                return HttpNotFound();
            }

            List<string> output = new List<string>();

            
           output.Add(answers.AnswerPrompts[0][guest.Question1]);
            output.Add(answers.AnswerPrompts[0][guest.Question2]);
            output.Add(answers.AnswerPrompts[0][guest.Question3]);
            output.Add(answers.AnswerPrompts[0][guest.Question4]);
            output.Add(answers.AnswerPrompts[0][guest.Question5]);
            output.Add(answers.AnswerPrompts[0][guest.Question6]);
            output.Add(answers.AnswerPrompts[0][guest.Question7]);
            output.Add(answers.AnswerPrompts[0][guest.Question8]);
            output.Add(answers.AnswerPrompts[0][guest.Question9]);
            output.Add(answers.AnswerPrompts[0][guest.Question10]);
            output.Add(answers.AnswerPrompts[0][guest.Question11]);
            output.Add(answers.AnswerPrompts[0][guest.Question12]);
            output.Add(answers.AnswerPrompts[0][guest.Question13]);
            output.Add(answers.AnswerPrompts[0][guest.Question14]);
            output.Add(answers.AnswerPrompts[0][guest.Question15]);

            ViewBag.printList = output;

            return View(guest);
        }
        // GET: Guests/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guest guest = await db.Guests.FindAsync(id);
            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }

        public ActionResult ViewMatches(int? id)
        {
            Guest me = db.Guests.Find(id);
            List<Guest> myGuestList = db.Guests.ToList();
            Dictionary<Guest, float> myResult = new Dictionary<Guest, float>();
            Answers answers = new Answers();
            int numAnswers = answers.GetSum();

            for (int i = 0; i < myGuestList.Count(); i++)
            {
                if (myGuestList[i].Id != me.Id) {
                    int diff = Math.Abs(me.Question1 - myGuestList[i].Question1);
                    diff += Math.Abs(me.Question2 - myGuestList[i].Question2);
                    diff += Math.Abs(me.Question3 - myGuestList[i].Question3);
                    diff += Math.Abs(me.Question4 - myGuestList[i].Question4);
                    diff += Math.Abs(me.Question5 - myGuestList[i].Question5);
                    diff += Math.Abs(me.Question6 - myGuestList[i].Question6);
                    diff += Math.Abs(me.Question7 - myGuestList[i].Question7);
                    diff += Math.Abs(me.Question8 - myGuestList[i].Question8);
                    diff += Math.Abs(me.Question9 - myGuestList[i].Question9);
                    diff += Math.Abs(me.Question10 - myGuestList[i].Question10);
                    diff += Math.Abs(me.Question11 - myGuestList[i].Question11);
                    diff += Math.Abs(me.Question12 - myGuestList[i].Question12);
                    diff += Math.Abs(me.Question13 - myGuestList[i].Question13);
                    diff += Math.Abs(me.Question14 - myGuestList[i].Question14);
                    diff += Math.Abs(me.Question15 - myGuestList[i].Question15);
                    int match = ((numAnswers - diff) / numAnswers) * 100; // Why is this zero?
                    myResult.Add(myGuestList[i], match);
                }
            }

            ViewBag.MatchList = myResult;
            return View();
        }

        // GET: Guests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Guests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Email,Password,FirstName,Age,Major,Job,Phone,Gender,Hometown,Question1,Question2,Question3,Question4,Question5,Question6,Question7,Question8,Question9,Question10,Question11,Question12,Question13,Question14,Question15")] Guest guest)
        {
            if (ModelState.IsValid)
            {
                db.Guests.Add(guest);
                await db.SaveChangesAsync();
                return RedirectToAction("Details/" + guest.Id);
            }

            return View(guest);
        }

        // GET: Guests/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guest guest = await db.Guests.FindAsync(id);
            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }

        // POST: Guests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Email,Password,FirstName,Age,Major,Job,Phone,Gender,Hometown,Question1,Question2,Question3,Question4,Question5,Question6,Question7,Question8,Question9,Question10,Question11,Question12,Question13,Question14,Question15")] Guest guest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guest).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(guest);
        }

        // GET: Guests/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guest guest = await db.Guests.FindAsync(id);
            if (guest == null)
            {
                return HttpNotFound();
            }
            return View(guest);
        }

        // POST: Guests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Guest guest = await db.Guests.FindAsync(id);
            db.Guests.Remove(guest);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
