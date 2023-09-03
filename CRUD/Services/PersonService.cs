using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Services
{
    public class PersonService
    {
        private readonly DatabaseContext _databaseContext;
        public PersonService(DatabaseContext databaseContext) 
        {          
            _databaseContext = databaseContext;
        }

        //Get all records
        public async Task<List<Person>> GetAllPerson()
        {
            return await _databaseContext.Persons.ToListAsync();
        }

        //Add new record
        public async Task<bool> AddNewPerson(Person person)
        {
            await _databaseContext.Persons.AddAsync(person);
            await _databaseContext.SaveChangesAsync();  
            return true;
        }

        //Get Person By Id
        public async Task<Person> GetPersonById(int id)
        {
            Person person = await _databaseContext.Persons.FirstOrDefaultAsync(x => x.Id == id);
            return person;
        }

        //Update Person Data
        public async Task<bool> UpdatePersonDetails(Person person)
        {
            _databaseContext.Persons.Update(person);
            await _databaseContext.SaveChangesAsync(true);
            return true;
        }
        public async Task<bool> DeletePerson(Person person)
        {
            _databaseContext.Persons.Remove(person);
            await _databaseContext.SaveChangesAsync(true);
            return true;
        }

    }
}
