﻿
using StaffManagementApp.DAL.Interface;
using StaffManagementApp.DAL.Repository;
using StaffManagementApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace StaffManagementApp.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IStaffInterface _staffService;
        public readonly Mock<IStaffRepository> staffservice = new Mock<IStaffRepository>();
        private readonly Staff _Staff;
        private readonly IEnumerable<Staff> StaffList;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
        {
            _staffService = new StaffManagementService(staffservice.Object);
            _output = output;
            _Staff = new Staff
            {
                StaffId = 1,
                FirstName = "Vicky",
                LastName = "Patel",
                DateOfBirth = DateTime.Now.Date,
                Email = "V@gmail.cm"
            };
            StaffList = new List<Staff>
        {
            new Staff
            {
               StaffId = 1,
                FirstName = "Vicky",
                LastName = "Patel",
                DateOfBirth = DateTime.Now.Date,
                Email = "V@gmail.cm"
            },
            new Staff
            {
              StaffId = 1,
                FirstName = "Vicky",
                LastName = "Patel",
                DateOfBirth = DateTime.Now.Date,
                Email = "V@gmail.cm"
            },
            // Add more Staff instances as needed
        };

        }

        [Fact]
        public async Task<bool> Testfor_Id_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                staffservice.Setup(repos => repos.GetStaffById(_Staff.StaffId)).Returns(_Staff);
                var result = _staffService.GetStaffById(_Staff.StaffId);

                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_FirstName_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                 staffservice.Setup(repos => repos.GetStaffById(_Staff.StaffId)).Returns(_Staff);
                var result =  _staffService.GetStaffById(_Staff.StaffId);

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        [Fact]
        public async Task<bool> Testfor_LastName_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                staffservice.Setup(repos => repos.GetStaffById(_Staff.StaffId)).Returns(_Staff);
                var result = _staffService.GetStaffById(_Staff.StaffId);

                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
       
        [Fact]
        public async Task<bool> Testfor_Date_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                 staffservice.Setup(repos => repos.GetStaffById(_Staff.StaffId)).Returns(_Staff);
                var result =  _staffService.GetStaffById(_Staff.StaffId);
               

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}