using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW_1.Models.DAL;

namespace HW_1.Models
{
    public class Episode
    {
        
        //---------data fields-------
        string name;
        int seasonNumber;
        string episodeName;
        string img;
        string description;
        string broadcastDate;

        //---------constructors-------
        public Episode()
        {

        }
        public Episode(string name, int seasonNumber, string episodeName, string img, string description, string broadcastDate)
        {
            this.name = name;
            this.seasonNumber = seasonNumber;
            this.episodeName = episodeName;
            this.img = img;
            this.description = description;
            this.broadcastDate = broadcastDate;
        }
        //properties
        public string Name { get => name; set => name = value; }
        public int SeasonNumber { get => seasonNumber; set => seasonNumber = value; }
        public string EpisodeName { get => episodeName; set => episodeName = value; }
        public string Img { get => img; set => img = value; }
        public string Description { get => description; set => description = value; }
        public string BroadcastDate { get => broadcastDate; set => broadcastDate = value; }


        public int Insert()
        {
            DataServices ds = new DataServices();
            ds.Insert(this);
            return 1;
        }

        public List<Episode> Get()
        {
            DataServices ds = new DataServices();
            List<Episode> sList = ds.Get();
            return sList;
        }

        public List<Episode> Get(string tvName)
        {
            DataServices ds = new DataServices();
            List<Episode> sList = ds.Get(tvName);
            return sList;
        }


    }



}