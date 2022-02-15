namespace GrpcServiceACCAMD.Data
{
    public class PersonRepository
    {

        private static List<PersonResponse> _personResponses = new List<PersonResponse>();

        public static async Task<PersonResponse> GetById(int id) {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }

        private static List<PersonResponse> GetAll()
        {
            return _personResponses = new List<PersonResponse>()
            {
                new PersonResponse() { Id = 1, FirstName = "Andres", LastName = "Collazos Certuche" },
                new PersonResponse() { Id = 2, FirstName = "Alejandro", LastName = "Martinez Delgado" },
                new PersonResponse() { Id = 3, FirstName = "Edgar", LastName = "Arciniegas" },
            };
        }



    }

    
}
