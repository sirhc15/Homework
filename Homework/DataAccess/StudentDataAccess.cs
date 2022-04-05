using Homework.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Homework.DataAccess
{
    public class StudentDataAccess : IStudentDataAccess
    {
        private readonly IConfiguration configuration;

        public StudentDataAccess(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            List<Student> students = new List<Student>();
            try
            {
                using (SqlConnection conn = new SqlConnection(configuration.GetConnectionString("StudentDatabase")))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "[dbo].[GetStudents]";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        conn.Open();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                students.Add(
                                    new Student(
                                        reader.GetInt32(0), 
                                        reader.GetString(1), 
                                        reader.GetString(2), 
                                        reader.GetString(3), 
                                        reader.GetString(4), 
                                        reader.GetString(5), 
                                        reader.GetInt32(6),
                                        reader.GetInt32(7))
                                    );
                            }
                        }
                    }
                }
                return students;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Contact>> GetContactsByStudentId(int studentId)
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                using (SqlConnection conn = new SqlConnection(configuration.GetConnectionString("StudentDatabase")))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "[dbo].[GetContactsByStudentId]";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@StudentId", studentId);
                        conn.Open();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                contacts.Add(
                                    new Contact(
                                        reader.GetInt32(0),
                                        reader.GetInt32(1),
                                        reader.GetString(2),
                                        reader.GetString(3),
                                        reader.GetString(4),
                                        reader.GetString(5),
                                        reader.GetString(6),
                                        reader.GetString(7),
                                        reader.GetString(8),
                                        reader.GetString(9),
                                        reader.GetInt32(10))
                                    );
                            }
                        }
                    }
                }
                return contacts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
