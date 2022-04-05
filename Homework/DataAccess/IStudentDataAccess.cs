using Homework.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Homework.DataAccess
{
    public interface IStudentDataAccess
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<IEnumerable<Contact>> GetContactsByStudentId(int studentId);
    }
}
