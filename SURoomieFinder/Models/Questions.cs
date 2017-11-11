using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SURoomieFinder.Models
{
	public class Questions
	{
		public Dictionary<string, int> MyQuestionDictionary = new Dictionary<string, int>();
		private static List<string> questions = new List<string>(new string[]{ "Which neighborhood do you want to live in?", "How much are you willing to spend per month on rent?", "What type of housing do you prefer?", "What pets do you currently have or plan to acquire?",
		"Do you drink alcohol?", "Do you smoke cigarettes?", "Are you 420 friendly?", "Do you partake in other substances not previously listed?", "How would you rate your own cleanliness in a living situation?", "What is your comfort with having guests in your living space?",
		"How much time do you spend at home?", "Do you prefer to live in housing with accomodations for people with disabilities?", "Do you prefer to live in housing with exclusively members of the LGBTQ+ community?", "Do you prefer to live with people of the same gender?",
		"What noise level are you comfortable with in your living situation?"});
		public Questions()
		{
			int length = questions.Count();

			for (int i = 0; i < length; i++)
			{
				MyQuestionDictionary.Add(questions[i], -1);
			}
		}
	}
}