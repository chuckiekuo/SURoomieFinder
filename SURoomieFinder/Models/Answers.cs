﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SURoomieFinder.Models
{
    public class Answers
    {
        public Guest myGuest;
		public int LengthAnswerPrompts;
		public List<List<string>> AnswerPrompts = new List<List<string>>();
		private static List<string> LocationAnswers = new List<string>(new string[] {"West Seattle", "South Downtown", "International District", "Downtown",
			"Capitol Hill", "Madrona", "Queen Anne", "Ballard", "Fremont", "University District" });
		private static List<string> PriceAnswers = new List<string>(new string[] { "$0 - $500", "$501 - $800", "$801 - $1,100", "$1,100 - $1,500", "$1,500+" });
		private static List<string> TypeAnswers = new List<string>(new string[] { "Small apartment", "High rise", "Duplex", "Full house" });
		private static List<string> PetAnswers = new List<string>(new string[] { "None", "Fish", "Amphibian", "Reptile", "Bird", "Vermin", "Cats", "Dogs", "Cats and Dogs"});
		private static List<string> DrinkingAnswers = new List<string>(new string[] {"No, and I DO mind if my roomie does",
			"No, and I DO NOT mind if my roomie does", "Yes (Occasionally)", "Yes (Often)" });
		private static List<string> SmokingAnswers = new List<string>(new string[] {"No, and I DO mind if my roomie does",
			"No, and I DO NOT mind if my roomie does", "Yes (Occasionally)", "Yes (Often)" });
		private static List<string> FourTwentyAnswers = new List<string>(new string[] {"No, and I DO mind if my roomie is",
			"No, and I DO NOT mind if my roomie is", "Yes (Occasionally)", "Yes (Often)" });
		private static List<string> SubstancesAnswers = new List<string>(new string[] {"No, and I DO mind if my roomie does",
			"No, and I DO NOT mind if my roomie does", "Yes (Occasionally)", "Yes (Often)" });
		private static List<string> CleanAnswers = new List<string>(new string[] {"Very messy", "Somewhat messy", "Not particularly clean or messy",
			"Somewhat clean", "Very clean" });
		private static List<string> GuestsAnswers = new List<string>(new string[] {"Prefer no guests", "Prefer somewhat infrequent guests",
			"Prefer somewhat frequent guests", "Prefer frequent guests" });
		private static List<string> TimeAnswers = new List<string>(new string[] {"Spend very little time at home", "Spend some leisure time at home",
			"Spend a good deal of leisure time at home", "Spend majority of leisure time at home" });
		private static List<string> DisabilityAnswers = new List<string>(new string[] { "Yes", "No" });
		private static List<string> LGBTQAnswers = new List<string>(new string[] { "Yes", "No" });
		private static List<string> GenderAnswers = new List<string>(new string[] { "Yes", "No" });
		private static List<string> NoiseAnswers = new List<string>(new string[] {"Very quiet", "Somewhat quiet", "Neither loud nor quiet",
			"Somewhat noisy", "Very noisy"});

		public Answers()
		{
			AnswerPrompts.Add(LocationAnswers);
			AnswerPrompts.Add(PriceAnswers);
			AnswerPrompts.Add(TypeAnswers);
			AnswerPrompts.Add(PetAnswers);
			AnswerPrompts.Add(DrinkingAnswers);
			AnswerPrompts.Add(SmokingAnswers);
			AnswerPrompts.Add(FourTwentyAnswers);
			AnswerPrompts.Add(SubstancesAnswers);
			AnswerPrompts.Add(CleanAnswers);
			AnswerPrompts.Add(GuestsAnswers);
			AnswerPrompts.Add(TimeAnswers);
			AnswerPrompts.Add(DisabilityAnswers);
			AnswerPrompts.Add(LGBTQAnswers);
			AnswerPrompts.Add(GenderAnswers);
			AnswerPrompts.Add(NoiseAnswers);
			LengthAnswerPrompts = AnswerPrompts.Count();
		}

        public Answers(Guest guest)
        {
            myGuest = guest;
            AnswerPrompts.Add(LocationAnswers);
            AnswerPrompts.Add(PriceAnswers);
            AnswerPrompts.Add(TypeAnswers);
            AnswerPrompts.Add(PetAnswers);
            AnswerPrompts.Add(DrinkingAnswers);
            AnswerPrompts.Add(SmokingAnswers);
            AnswerPrompts.Add(FourTwentyAnswers);
            AnswerPrompts.Add(SubstancesAnswers);
            AnswerPrompts.Add(CleanAnswers);
            AnswerPrompts.Add(GuestsAnswers);
            AnswerPrompts.Add(TimeAnswers);
            AnswerPrompts.Add(DisabilityAnswers);
            AnswerPrompts.Add(LGBTQAnswers);
            AnswerPrompts.Add(GenderAnswers);
            AnswerPrompts.Add(NoiseAnswers);
            LengthAnswerPrompts = AnswerPrompts.Count();
        }

        public int GetSum()
		{
			int total = 0;
			for (int i = 0; i < LengthAnswerPrompts; i++)
			{
				total += AnswerPrompts[i].Count();
			}
			return total;
		}



	     


	}
}