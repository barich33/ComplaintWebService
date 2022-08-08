
using CWS.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CWS.Service.People
{
    public interface IPeopleService
    {
        Task<PeopleDTO> GetAllPeoples();
    }
}
