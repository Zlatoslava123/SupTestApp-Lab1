using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using SupTestApp_Lab1;

namespace Tests
{
    [TestClass]
    public class ReportTests
    {
        [TestMethod]
        public void Test_CreateReport()
        {
            Report report = new Report("Test", "Content", DateTime.Now);
            Assert.IsNotNull(report);
        }

        [TestMethod]
        public void Test_ReportTitle()
        {
            Report report = new Report("My Report", "Content", DateTime.Now);
            string expected = "My Report";
            string actual = report.Title;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ReportContent()
        {
            Report report = new Report("Title", "My Content", DateTime.Now);
            string expected = "My Content";
            string actual = report.Content;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ToStringContainsTitle()
        {
            Report report = new Report("Report", "Text", new DateTime(2026, 5, 21));
            string result = report.ToString();
            bool contains = result.Contains("Report");
            Assert.IsTrue(contains);
        }
    }

    [TestClass]
    public class ManagerTests
    {
        [TestMethod]
        public void Test_AddReport()
        {
            ReportManager manager = new ReportManager();
            Report report = new Report("Test", "Content", DateTime.Now);

            manager.AddReport(report);

            int expected = 1;
            int actual = manager.Reports.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_RemoveReport()
        {
            ReportManager manager = new ReportManager();
            Report report = new Report("Test", "Content", DateTime.Now);
            manager.AddReport(report);

            manager.RemoveReport(report);

            int expected = 0;
            int actual = manager.Reports.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}