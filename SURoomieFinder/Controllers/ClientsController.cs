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
    public class ClientsController : Controller
    {
        private ClientDbContext db = new ClientDbContext();

        // GET: Clients
        public async Task<ActionResult> Index()
        {
            return View(await db.Clients.ToListAsync());
        }

        public ActionResult QuestionDetails(string id = null)
        {

            int myID = 0;

            if (!Int32.TryParse(id, out myID))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var myClient = db.Clients.Find(myID);

            string response = "";
            int i = 0;
            Dictionary<string, string> output = new Dictionary<string, string>();

            foreach (KeyValuePair<string, int> entry in myClient.QuestionList.MyQuestionDictionary){

                switch (entry.Value)
                {
                    case -1:
                        response = "Not answered";
                        break;
                }

                output.Add(entry.Key, response);
            }

            ViewBag.QuestionsDictionary = output;
            return View();
        }
        // GET: Clients/Details/5
        public async Task<ActionResult> Details(string id = null)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            int myID = 0;

            if (!Int32.TryParse(id, out myID))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Client client = await db.Clients.FindAsync(myID);

            if (client == null)
            {
                return HttpNotFound();
            }

            return View(client);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = 
            "Id,Email,Password,FirstName,Age,Major,Job,Phone,Gender,Hometown"
            )] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Clients.Add(client);
                await db.SaveChangesAsync();
                return RedirectToAction("Details/" + client.Id);//, client.Id);
            }

            return View(client);
        }

        // GET: Clients/Edit/5
        public async Task<ActionResult> Edit(string id = null)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            int myID = 0;

            if (!Int32.TryParse(id, out myID))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Client client = await db.Clients.FindAsync(myID);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = 
            "Id,Email,Password,FirstName,Age,Major,Job,Phone,Gender,Hometown")
            ] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(client);
        }

        // GET: Clients/Delete/5
        public async Task<ActionResult> Delete(string id = null)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            int myID = 0;

            if (!Int32.TryParse(id, out myID))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Client client = await db.Clients.FindAsync(myID);

            if (client == null)
            {
                return HttpNotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Client client = await db.Clients.FindAsync(id);
            db.Clients.Remove(client);
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
