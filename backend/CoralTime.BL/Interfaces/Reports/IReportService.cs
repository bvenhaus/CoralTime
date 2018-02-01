﻿using CoralTime.ViewModels.Reports;
using CoralTime.ViewModels.Reports.Request.Grid;
using CoralTime.ViewModels.Reports.Responce.DropDowns.Filters;
using System;

namespace CoralTime.BL.Interfaces.Reports
{
    public interface IReportService
    {
        DateTime DateFrom { get; set; }

        DateTime DateTo { get; set; }

        ReportsDropDownsView ReportsDropDowns(string userName);

        void SaveCurrentQuery(ReportsSettingsView reportsSettings, string userName);

        void SaveCustomQuery(ReportsSettingsView reportsSettings, string userName);

        void DeleteCustomQuery(int id, string userName);

        ReportsGrandGridTimeEntryView ReportsGridGroupByNone(string userName, ReportsGridView reportsGridData);

        ReportsGrandGridProjectsView ReportsGridGroupByProjects(string userName, ReportsGridView reportsGridData);

        ReportsGrandGridMembersView ReportsGridGroupByUsers(string userName, ReportsGridView reportsGridData);

        ReportsGrandGridDatesView ReportsGridGroupByDates(string userName, ReportsGridView reportsGridData);

        ReportsGrandGridClients ReportsGridGroupByClients(string userName, ReportsGridView reportsGridData);
    }
}