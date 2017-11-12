using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace SURoomieFinder.Models
{
    public class Responses
    {
        public Guest myClient;
        public int myMatchScore;

        public Responses(Guest client, int matchScore)
        {
            myClient = client;
            myMatchScore = matchScore;
        }

	}

}