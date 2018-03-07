using System;
using System.Collections.Generic;
using System.Text;
using CoreRest.Model;
using CoreRest.Model.Enums;

namespace CoreRest.Repository
{
    public class DummyData: IData
    {
        public IReadOnlyList<Employee> Employees()
        {

            return new List<Employee> {
                new Employee {
<<<<<<< HEAD
                    EmployeeId = Guid.Parse("1238648F-3DBA-1234-8DF5-B5F043351234"),
=======
                    EmployeeId = Guid.Parse("1238648F-3DBA-1234-8DF5-B5F0433053F8"),
>>>>>>> 260063ffb7cad76efab1d4e31aace4f346ab4158
                    Name = "Bob",
                    LastName = "Marley",
                    Profile = new Profile
                    {
<<<<<<< HEAD
                        ProfileId = Guid.Parse("2238648F-E7A1-4C4E-A77A-B5F043391234"),
=======
                        ProfileId = Guid.Parse("1236BAE6-E7A1-4C4E-A77A-535CBDDA1234"),
>>>>>>> 260063ffb7cad76efab1d4e31aace4f346ab4158
                        ProfileCode = "A1234",
                        Skills = new List<Skills> { Skills.CoreMVC},
                        Department = new Department { DepartmentCode= "SW" ,DepartmentDesc="Software Development"}
                    }
                },
                 new Employee {
<<<<<<< HEAD
                    EmployeeId = Guid.Parse("3238648F-3DBA-1234-8DF5-B5F043361234"),
=======
                    EmployeeId = Guid.Parse("54321648F-3DBA-1234-8DF5-B5F0433053F8"),
>>>>>>> 260063ffb7cad76efab1d4e31aace4f346ab4158
                    Name = "Jack",
                    LastName = "London",
                    Profile = new Profile
                    {
<<<<<<< HEAD
                        ProfileId = Guid.Parse("4238648F-E7A1-4C4E-A77A-B5F043311234"),
=======
                        ProfileId = Guid.Parse("54321BAE6-E7A1-4C4E-A77A-535CBDDA1234"),
>>>>>>> 260063ffb7cad76efab1d4e31aace4f346ab4158
                        ProfileCode = "B1234",
                        Skills = new List<Skills> { Skills.Scala},
                        Department = new Department { DepartmentCode= "PS" ,DepartmentDesc="Professional Services"}
                    }
                },
                 new Employee {
<<<<<<< HEAD
                    EmployeeId = Guid.Parse("5238648F-3DBA-1234-8DF5-B5F043321234"),
=======
                    EmployeeId = Guid.Parse("64321648F-3DBA-1234-8DF5-B5F0433053F8"),
>>>>>>> 260063ffb7cad76efab1d4e31aace4f346ab4158
                    Name = "Mark",
                    LastName = "Twain",
                    Profile = new Profile
                    {
<<<<<<< HEAD
                        ProfileId = Guid.Parse("6238648F-E7A1-4C4E-A77A-B5F043341234"),
=======
                        ProfileId = Guid.Parse("84321BAE6-E7A1-4C4E-A77A-535CBDDA1234"),
>>>>>>> 260063ffb7cad76efab1d4e31aace4f346ab4158
                        ProfileCode = "C1234",
                        Skills = new List<Skills> { Skills.Scala},
                        Department = new Department { DepartmentCode= "SW" ,DepartmentDesc="Software Development "}
                    }
                }

                };
           
        }

        public List<Profile> Profile()
        {
            return new List<Profile>
           {
                new Profile
                {
<<<<<<< HEAD
                    ProfileId = Guid.Parse("1236BAE6-E7A1-4C4E-A77A-535CBDD91234"),
=======
                    ProfileId = Guid.Parse("1236BAE6-E7A1-4C4E-A77A-535CBDDA9999"),
>>>>>>> 260063ffb7cad76efab1d4e31aace4f346ab4158
                        ProfileCode = "D1234",
                        Skills = new List<Skills> { Skills.Go},
                        Department = new Department { DepartmentCode= "SW" ,DepartmentDesc="Software Development"}
                },
                new Profile
                {
<<<<<<< HEAD
                    ProfileId = Guid.Parse("8886BAE6-E7A1-4C4E-A77A-535CBDD81234"),
=======
                    ProfileId = Guid.Parse("8886BAE6-E7A1-4C4E-A77A-535CBDDA9999"),
>>>>>>> 260063ffb7cad76efab1d4e31aace4f346ab4158
                        ProfileCode = "E1234",
                        Skills = new List<Skills> { Skills.SpringMVC},
                        Department = new Department { DepartmentCode= "SW" ,DepartmentDesc="Software Development"}
                },
                new Profile
                {
<<<<<<< HEAD
                    ProfileId = Guid.Parse("7777BAE6-E7A1-4C4E-A77A-535CBDD71234"),
=======
                    ProfileId = Guid.Parse("7777BAE6-E7A1-4C4E-A77A-535CBDDA9999"),
>>>>>>> 260063ffb7cad76efab1d4e31aace4f346ab4158
                        ProfileCode = "D1234",
                        Skills = new List<Skills> { Skills.CoreMVC},
                        Department = new Department { DepartmentCode= "SW" ,DepartmentDesc="Software Development"}
                }
                

           };


        }

       
    }
}
