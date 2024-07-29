using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVersioning
{
    public class ApplicationFactory<T> : WebApplicationFactory<T> where T : class
    {

    }
}
