using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW_1.Models.DAL
{
    public class DataServices
    {
        static List<Episode> episodeList;
        static List<User> userList;
        public int InsertUserDS(User user)
        {
            Console.WriteLine("InsertUser - dataservise.cs step 3");

            if (userList == null)
                userList = new List<User>();

            userList.Add(user);

            return 1;
        }
        public int Insert(Episode episode)
        {
            if (episodeList == null)
                episodeList = new List<Episode>();

            episodeList.Add(episode);

            return 1;
        }
        public List<Episode> Get()
        {
            return episodeList;
        }
        public List<Episode> Get(string tvName)
        {
            List<Episode> filteredList = new List<Episode>();
            Console.WriteLine(tvName);
            foreach (Episode e in episodeList){      
                if (e.Name.Contains(tvName))
                    filteredList.Add(e);
            }
            return filteredList;
        }
    }
}