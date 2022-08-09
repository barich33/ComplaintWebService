using CWS.Service.DTOs;

namespace CWS.API.Model
{
    public class SearchResultVM
    {
        public PeopleDTO Peoples { get; set; }
        public JokeDTO Jokes { get; set; }
    }
}
