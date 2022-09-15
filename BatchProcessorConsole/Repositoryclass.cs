using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using StockTrackerApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBClassLibrary;
using DBClassLibrary.Models;
//using Microsoft.EntityFrameworkCore;
//using ConsoleApp_DB.Models;
namespace BatchProcessorConsole
{
    public class Repositoryclass
    {
        TrackerContext context;

        public Repositoryclass(TrackerContext _context)
        {
            context = _context;
        }

        public Header GetHeader()
        {
            Header header = context.HeaderTable.FirstOrDefault<Header>(p => p.Key == "ed8bbc525fmshe7f2ca46e69c3ffp179016jsne9ad147cd3e0");
            return header;
        }
    }
}

//add in ANOTHER CLASS library