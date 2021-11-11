using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ProjetoN2.Models;

namespace ProjetoN2.Service
{
    public interface ISeedingService
    {
        void Seed();
    }
}