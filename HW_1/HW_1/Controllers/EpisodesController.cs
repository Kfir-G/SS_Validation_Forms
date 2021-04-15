using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HW_1.Models;


namespace HW_1.Controllers
{
    public class EpisodesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Episode> Get()
        {
            Episode episode = new Episode();
            List<Episode> episodeList = episode.Get();
            return episodeList;
        }

        // GET api/<controller>?tvName="string"
        public IEnumerable<Episode> Get(string tvName)
        {
            Episode e = new Episode();
            List<Episode> sList = e.Get(tvName);
            return sList;
        }

        // POST api/<controller>
        public int Post([FromBody] Episode episode)
        {
            episode.Insert();
            return 1;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}