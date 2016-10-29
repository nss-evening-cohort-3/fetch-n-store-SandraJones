using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fetch_and_Store.Models;
using Microsoft.Ajax.Utilities;

namespace Fetch_and_Store.DAL
{
    public class ResponseRepo
    {
        public RepoContext Context{get; set;}

        public ResponseRepo()
        {
            Context = new RepoContext();
        }
        public ResponseRepo(RepoContext _context)
        {
            Context = _context;
        }
    }
}