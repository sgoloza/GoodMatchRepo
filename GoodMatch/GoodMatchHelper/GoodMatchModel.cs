using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodMatch.GoodMatchHelper
{
    public class GoodMatchModel
    {
        public string Player1Name { get; set; }
        public string Palyer2Name { get; set; }
        public IFormFile nextofKin { get; set; }
    }
}
