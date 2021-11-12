﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Timelines.Models;

namespace Timelines.Migrations
{
    [DbContext(typeof(TimelinesContext))]
    partial class TimelinesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113");

            modelBuilder.Entity("Timelines.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ACDandEvalReportOnWeb");

                    b.Property<int>("ACID");

                    b.Property<DateTime>("ActualLicenceDates");

                    b.Property<string>("AnticipatedLicenceDates");

                    b.Property<string>("Appraisal");

                    b.Property<string>("CommitteeLetter");

                    b.Property<DateTime>("CommitteeMeeting");

                    b.Property<string>("CommitteeStream");

                    b.Property<DateTime>("DateOfDraftScopeConsultation");

                    b.Property<DateTime>("DeadlineForERGReceipt");

                    b.Property<string>("ERG");

                    b.Property<DateTime>("FADPublished");

                    b.Property<DateTime>("FirstMeeting");

                    b.Property<DateTime>("InvitationToParticipate");

                    b.Property<string>("LatestMasterNote");

                    b.Property<string>("ProcessType");

                    b.Property<DateTime>("PublicationDate");

                    b.Property<DateTime>("SendSubmissionToERG");

                    b.Property<string>("Status");

                    b.HasKey("ScheduleId");

                    b.ToTable("Schedules");
                });
#pragma warning restore 612, 618
        }
    }
}
