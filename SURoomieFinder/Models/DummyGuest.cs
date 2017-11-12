using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SURoomieFinder.Models
{
    public class DummyGuest
    {
        public string FirstName;
        public int Id;
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; } Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12, Q13, Q14, Q15;
           
        public DummyGuest(Guest guest)
        {
            Answers answerList = new Answers();
            FirstName = guest.FirstName;
            Id = guest.Id;
            Q1 = answerList.AnswerPrompts[0][guest.Question1];
            Q2 = answerList.AnswerPrompts[1][guest.Question2];
            Q3 = answerList.AnswerPrompts[2][guest.Question3];
            Q4 = answerList.AnswerPrompts[3][guest.Question4];
            Q5 = answerList.AnswerPrompts[4][guest.Question5];
            Q6 = answerList.AnswerPrompts[5][guest.Question6];
            Q7 = answerList.AnswerPrompts[6][guest.Question7];
            Q8 = answerList.AnswerPrompts[7][guest.Question8];
            Q9 = answerList.AnswerPrompts[8][guest.Question9];
            Q10 = answerList.AnswerPrompts[9][guest.Question10];
            Q11 = answerList.AnswerPrompts[10][guest.Question11];
            Q12 = answerList.AnswerPrompts[11][guest.Question12];
            Q13 = answerList.AnswerPrompts[12][guest.Question13];
            Q14 = answerList.AnswerPrompts[13][guest.Question14];
            Q15 = answerList.AnswerPrompts[14][guest.Question15];
        }
    }
}