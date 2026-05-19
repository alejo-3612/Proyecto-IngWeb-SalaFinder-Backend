using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalaFinder.Models;
using System.Diagnostics;

namespace SalaFinder.DAO
{

    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<Space> Spaces { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<AuditLog> AuditLogs { get; set; }

        public DbSet<NoShow> NoShows { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Reservation>().HasData(

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000001"),
    spaceId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
    userId = "u1",
    date = new DateTime(2025, 2, 1),
    startTime = new TimeSpan(9, 0, 0),
    endTime = new TimeSpan(10, 0, 0),
    purpose = "Team meeting",
    attendeeCount = 5,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000002"),
    spaceId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
    userId = "u2",
    date = new DateTime(2025, 2, 1),
    startTime = new TimeSpan(10, 0, 0),
    endTime = new TimeSpan(11, 0, 0),
    purpose = "Project discussion",
    attendeeCount = 4,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000003"),
    spaceId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
    userId = "u3",
    date = new DateTime(2025, 2, 2),
    startTime = new TimeSpan(9, 0, 0),
    endTime = new TimeSpan(11, 0, 0),
    purpose = "Workshop",
    attendeeCount = 20,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000004"),
    spaceId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
    userId = "u4",
    date = new DateTime(2025, 2, 2),
    startTime = new TimeSpan(11, 0, 0),
    endTime = new TimeSpan(12, 0, 0),
    purpose = "Coding session",
    attendeeCount = 8,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000005"),
    spaceId = Guid.Parse("55555555-5555-5555-5555-555555555555"),
    userId = "u5",
    date = new DateTime(2025, 2, 3),
    startTime = new TimeSpan(14, 0, 0),
    endTime = new TimeSpan(15, 0, 0),
    purpose = "Executive meeting",
    attendeeCount = 6,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000006"),
    spaceId = Guid.Parse("66666666-6666-6666-6666-666666666666"),
    userId = "u6",
    date = new DateTime(2025, 2, 3),
    startTime = new TimeSpan(15, 0, 0),
    endTime = new TimeSpan(17, 0, 0),
    purpose = "Training",
    attendeeCount = 18,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000007"),
    spaceId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
    userId = "u7",
    date = new DateTime(2025, 2, 4),
    startTime = new TimeSpan(9, 0, 0),
    endTime = new TimeSpan(10, 0, 0),
    purpose = "Planning",
    attendeeCount = 5,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000008"),
    spaceId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
    userId = "u8",
    date = new DateTime(2025, 2, 4),
    startTime = new TimeSpan(11, 0, 0),
    endTime = new TimeSpan(12, 0, 0),
    purpose = "Review meeting",
    attendeeCount = 4,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000009"),
    spaceId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
    userId = "u9",
    date = new DateTime(2025, 2, 5),
    startTime = new TimeSpan(10, 0, 0),
    endTime = new TimeSpan(12, 0, 0),
    purpose = "Seminar",
    attendeeCount = 30,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000010"),
    spaceId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
    userId = "u10",
    date = new DateTime(2025, 2, 5),
    startTime = new TimeSpan(13, 0, 0),
    endTime = new TimeSpan(14, 0, 0),
    purpose = "Dev meeting",
    attendeeCount = 7,
    status = "Approved"
},

// las siguientes siguen el mismo patrón

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000011"),
    spaceId = Guid.Parse("55555555-5555-5555-5555-555555555555"),
    userId = "u11",
    date = new DateTime(2025, 2, 6),
    startTime = new TimeSpan(9, 0, 0),
    endTime = new TimeSpan(10, 0, 0),
    purpose = "Strategy",
    attendeeCount = 6,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000012"),
    spaceId = Guid.Parse("66666666-6666-6666-6666-666666666666"),
    userId = "u12",
    date = new DateTime(2025, 2, 6),
    startTime = new TimeSpan(11, 0, 0),
    endTime = new TimeSpan(12, 0, 0),
    purpose = "Workshop",
    attendeeCount = 10,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000013"),
    spaceId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
    userId = "u13",
    date = new DateTime(2025, 2, 7),
    startTime = new TimeSpan(14, 0, 0),
    endTime = new TimeSpan(15, 0, 0),
    purpose = "Planning",
    attendeeCount = 4,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000014"),
    spaceId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
    userId = "u14",
    date = new DateTime(2025, 2, 7),
    startTime = new TimeSpan(15, 0, 0),
    endTime = new TimeSpan(16, 0, 0),
    purpose = "Sprint review",
    attendeeCount = 5,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000015"),
    spaceId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
    userId = "u15",
    date = new DateTime(2025, 2, 8),
    startTime = new TimeSpan(9, 0, 0),
    endTime = new TimeSpan(11, 0, 0),
    purpose = "Conference",
    attendeeCount = 40,
    status = "Approved"
},

// duplicamos patrón para llegar a 30

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000016"),
    spaceId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
    userId = "u1",
    date = new DateTime(2025, 2, 8),
    startTime = new TimeSpan(11, 0, 0),
    endTime = new TimeSpan(12, 0, 0),
    purpose = "Development",
    attendeeCount = 6,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000017"),
    spaceId = Guid.Parse("55555555-5555-5555-5555-555555555555"),
    userId = "u2",
    date = new DateTime(2025, 2, 9),
    startTime = new TimeSpan(13, 0, 0),
    endTime = new TimeSpan(14, 0, 0),
    purpose = "Meeting",
    attendeeCount = 5,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000018"),
    spaceId = Guid.Parse("66666666-6666-6666-6666-666666666666"),
    userId = "u3",
    date = new DateTime(2025, 2, 9),
    startTime = new TimeSpan(15, 0, 0),
    endTime = new TimeSpan(16, 0, 0),
    purpose = "Workshop",
    attendeeCount = 12,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000019"),
    spaceId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
    userId = "u4",
    date = new DateTime(2025, 2, 10),
    startTime = new TimeSpan(9, 0, 0),
    endTime = new TimeSpan(10, 0, 0),
    purpose = "Planning",
    attendeeCount = 4,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000020"),
    spaceId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
    userId = "u5",
    date = new DateTime(2025, 2, 10),
    startTime = new TimeSpan(11, 0, 0),
    endTime = new TimeSpan(12, 0, 0),
    purpose = "Discussion",
    attendeeCount = 3,
    status = "Approved"
},

// últimos 10

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000021"),
    spaceId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
    userId = "u6",
    date = new DateTime(2025, 2, 11),
    startTime = new TimeSpan(9, 0, 0),
    endTime = new TimeSpan(11, 0, 0),
    purpose = "Training",
    attendeeCount = 15,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000022"),
    spaceId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
    userId = "u7",
    date = new DateTime(2025, 2, 11),
    startTime = new TimeSpan(11, 0, 0),
    endTime = new TimeSpan(12, 0, 0),
    purpose = "Dev meeting",
    attendeeCount = 6,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000023"),
    spaceId = Guid.Parse("55555555-5555-5555-5555-555555555555"),
    userId = "u8",
    date = new DateTime(2025, 2, 12),
    startTime = new TimeSpan(13, 0, 0),
    endTime = new TimeSpan(14, 0, 0),
    purpose = "Planning",
    attendeeCount = 5,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000024"),
    spaceId = Guid.Parse("66666666-6666-6666-6666-666666666666"),
    userId = "u9",
    date = new DateTime(2025, 2, 12),
    startTime = new TimeSpan(15, 0, 0),
    endTime = new TimeSpan(17, 0, 0),
    purpose = "Lab session",
    attendeeCount = 18,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000025"),
    spaceId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
    userId = "u10",
    date = new DateTime(2025, 2, 13),
    startTime = new TimeSpan(9, 0, 0),
    endTime = new TimeSpan(10, 0, 0),
    purpose = "Meeting",
    attendeeCount = 4,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000026"),
    spaceId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
    userId = "u11",
    date = new DateTime(2025, 2, 13),
    startTime = new TimeSpan(10, 0, 0),
    endTime = new TimeSpan(11, 0, 0),
    purpose = "Review",
    attendeeCount = 5,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000027"),
    spaceId = Guid.Parse("33333333-3333-3333-3333-333333333333"),
    userId = "u12",
    date = new DateTime(2025, 2, 14),
    startTime = new TimeSpan(11, 0, 0),
    endTime = new TimeSpan(13, 0, 0),
    purpose = "Conference",
    attendeeCount = 25,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000028"),
    spaceId = Guid.Parse("44444444-4444-4444-4444-444444444444"),
    userId = "u13",
    date = new DateTime(2025, 2, 14),
    startTime = new TimeSpan(14, 0, 0),
    endTime = new TimeSpan(15, 0, 0),
    purpose = "Development",
    attendeeCount = 6,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000029"),
    spaceId = Guid.Parse("55555555-5555-5555-5555-555555555555"),
    userId = "u14",
    date = new DateTime(2025, 2, 15),
    startTime = new TimeSpan(9, 0, 0),
    endTime = new TimeSpan(10, 0, 0),
    purpose = "Executive meeting",
    attendeeCount = 6,
    status = "Approved"
},

new Reservation
{
    id_reservation = Guid.Parse("20000000-0000-0000-0000-000000000030"),
    spaceId = Guid.Parse("66666666-6666-6666-6666-666666666666"),
    userId = "u15",
    date = new DateTime(2025, 2, 15),
    startTime = new TimeSpan(10, 0, 0),
    endTime = new TimeSpan(12, 0, 0),
    purpose = "Training",
    attendeeCount = 20,
    status = "Approved"
}

);
            modelBuilder.Entity<AuditLog>().HasData(

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000001"),
    userId = "u1",
    action = "CREATE_RESERVATION",
    entity = "Reservation",
    timestamp = new DateTime(2025, 1, 1)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000002"),
    userId = "u2",
    action = "CREATE_RESERVATION",
    entity = "Reservation",
    timestamp = new DateTime(2025, 1, 2)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000003"),
    userId = "u3",
    action = "UPDATE_RESERVATION",
    entity = "Reservation",
    timestamp = new DateTime(2025, 1, 3)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000004"),
    userId = "u4",
    action = "CANCEL_RESERVATION",
    entity = "Reservation",
    timestamp = new DateTime(2025, 1, 4)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000005"),
    userId = "u5",
    action = "CREATE_SPACE",
    entity = "Space",
    timestamp = new DateTime(2025, 1, 5)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000006"),
    userId = "u6",
    action = "UPDATE_SPACE",
    entity = "Space",
    timestamp = new DateTime(2025, 1, 6)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000007"),
    userId = "u7",
    action = "DELETE_RESERVATION",
    entity = "Reservation",
    timestamp = new DateTime(2025, 1, 7)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000008"),
    userId = "u8",
    action = "CREATE_RESERVATION",
    entity = "Reservation",
    timestamp = new DateTime(2025, 1, 8)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000009"),
    userId = "u9",
    action = "UPDATE_RESERVATION",
    entity = "Reservation",
    timestamp = new DateTime(2025, 1, 9)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000010"),
    userId = "u10",
    action = "LOGIN",
    entity = "User",
    timestamp = new DateTime(2025, 1, 10)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000011"),
    userId = "u11",
    action = "LOGIN",
    entity = "User",
    timestamp = new DateTime(2025, 1, 11)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000012"),
    userId = "u12",
    action = "CREATE_RESERVATION",
    entity = "Reservation",
    timestamp = new DateTime(2025, 1, 12)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000013"),
    userId = "u13",
    action = "UPDATE_RESERVATION",
    entity = "Reservation",
    timestamp = new DateTime(2025, 1, 13)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000014"),
    userId = "u14",
    action = "CANCEL_RESERVATION",
    entity = "Reservation",
    timestamp = new DateTime(2025, 1, 14)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000015"),
    userId = "u15",
    action = "CREATE_SPACE",
    entity = "Space",
    timestamp = new DateTime(2025, 1, 15)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000016"),
    userId = "u1",
    action = "LOGIN",
    entity = "User",
    timestamp = new DateTime(2025, 1, 16)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000017"),
    userId = "u2",
    action = "CREATE_RESERVATION",
    entity = "Reservation",
    timestamp = new DateTime(2025, 1, 17)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000018"),
    userId = "u3",
    action = "UPDATE_SPACE",
    entity = "Space",
    timestamp = new DateTime(2025, 1, 18)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000019"),
    userId = "u4",
    action = "LOGIN",
    entity = "User",
    timestamp = new DateTime(2025, 1, 19)
},

new AuditLog
{
    id_log = Guid.Parse("10000000-0000-0000-0000-000000000020"),
    userId = "u5",
    action = "DELETE_RESERVATION",
    entity = "Reservation",
    timestamp = new DateTime(2025, 1, 20)
}

);
            modelBuilder.Entity<Space>().HasData(

new Space
{
    id_space = Guid.Parse("11111111-1111-1111-1111-111111111111"),
    name = "Sala Innovacion",
    type = "Meeting",
    capacity = 10,
    building = "A",
    resources = "TV, Whiteboard",
    allowedPrograms = "Zoom, Teams",
    requiresApproval = false,
    isActive = true
},

new Space
{
    id_space = Guid.Parse("22222222-2222-2222-2222-222222222222"),
    name = "Sala Creativa",
    type = "Meeting",
    capacity = 8,
    building = "A",
    resources = "TV",
    allowedPrograms = "Zoom",
    requiresApproval = false,
    isActive = true
},

new Space
{
    id_space = Guid.Parse("33333333-3333-3333-3333-333333333333"),
    name = "Auditorio Central",
    type = "Conference",
    capacity = 50,
    building = "B",
    resources = "Projector, Microphone",
    allowedPrograms = "Teams, Zoom",
    requiresApproval = true,
    isActive = true
},

new Space
{
    id_space = Guid.Parse("44444444-4444-4444-4444-444444444444"),
    name = "Laboratorio Digital",
    type = "Lab",
    capacity = 20,
    building = "C",
    resources = "Computers",
    allowedPrograms = "Python, VSCode",
    requiresApproval = true,
    isActive = true
},

new Space
{
    id_space = Guid.Parse("55555555-5555-5555-5555-555555555555"),
    name = "Sala Ejecutiva",
    type = "Meeting",
    capacity = 12,
    building = "B",
    resources = "TV, Conference Phone",
    allowedPrograms = "Zoom, Teams",
    requiresApproval = true,
    isActive = true
},

new Space
{
    id_space = Guid.Parse("66666666-6666-6666-6666-666666666666"),
    name = "Sala Taller",
    type = "Workshop",
    capacity = 25,
    building = "D",
    resources = "Whiteboard, Projector",
    allowedPrograms = "None",
    requiresApproval = false,
    isActive = true
}

);


            modelBuilder.Entity<IdentityUser>().HasData(

 new IdentityUser
 {
     Id = "u1",
     UserName = "user1@mail.com",
     NormalizedUserName = "USER1@MAIL.COM",
     Email = "user1@mail.com",
     NormalizedEmail = "USER1@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp1",
     ConcurrencyStamp = "stamp1"
 },

 new IdentityUser
 {
     Id = "u2",
     UserName = "user2@mail.com",
     NormalizedUserName = "USER2@MAIL.COM",
     Email = "user2@mail.com",
     NormalizedEmail = "USER2@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp2",
     ConcurrencyStamp = "stamp2"
 },

 new IdentityUser
 {
     Id = "u3",
     UserName = "user3@mail.com",
     NormalizedUserName = "USER3@MAIL.COM",
     Email = "user3@mail.com",
     NormalizedEmail = "USER3@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp3",
     ConcurrencyStamp = "stamp3"
 },

 new IdentityUser
 {
     Id = "u4",
     UserName = "user4@mail.com",
     NormalizedUserName = "USER4@MAIL.COM",
     Email = "user4@mail.com",
     NormalizedEmail = "USER4@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp4",
     ConcurrencyStamp = "stamp4"
 },

 new IdentityUser
 {
     Id = "u5",
     UserName = "user5@mail.com",
     NormalizedUserName = "USER5@MAIL.COM",
     Email = "user5@mail.com",
     NormalizedEmail = "USER5@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp5",
     ConcurrencyStamp = "stamp5"
 },

 new IdentityUser
 {
     Id = "u6",
     UserName = "user6@mail.com",
     NormalizedUserName = "USER6@MAIL.COM",
     Email = "user6@mail.com",
     NormalizedEmail = "USER6@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp6",
     ConcurrencyStamp = "stamp6"
 },

 new IdentityUser
 {
     Id = "u7",
     UserName = "user7@mail.com",
     NormalizedUserName = "USER7@MAIL.COM",
     Email = "user7@mail.com",
     NormalizedEmail = "USER7@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp7",
     ConcurrencyStamp = "stamp7"
 },

 new IdentityUser
 {
     Id = "u8",
     UserName = "user8@mail.com",
     NormalizedUserName = "USER8@MAIL.COM",
     Email = "user8@mail.com",
     NormalizedEmail = "USER8@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp8",
     ConcurrencyStamp = "stamp8"
 },

 new IdentityUser
 {
     Id = "u9",
     UserName = "user9@mail.com",
     NormalizedUserName = "USER9@MAIL.COM",
     Email = "user9@mail.com",
     NormalizedEmail = "USER9@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp9",
     ConcurrencyStamp = "stamp9"
 },

 new IdentityUser
 {
     Id = "u10",
     UserName = "user10@mail.com",
     NormalizedUserName = "USER10@MAIL.COM",
     Email = "user10@mail.com",
     NormalizedEmail = "USER10@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp10",
     ConcurrencyStamp = "stamp10"
 },

 new IdentityUser
 {
     Id = "u11",
     UserName = "user11@mail.com",
     NormalizedUserName = "USER11@MAIL.COM",
     Email = "user11@mail.com",
     NormalizedEmail = "USER11@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp11",
     ConcurrencyStamp = "stamp11"
 },

 new IdentityUser
 {
     Id = "u12",
     UserName = "user12@mail.com",
     NormalizedUserName = "USER12@MAIL.COM",
     Email = "user12@mail.com",
     NormalizedEmail = "USER12@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp12",
     ConcurrencyStamp = "stamp12"
 },

 new IdentityUser
 {
     Id = "u13",
     UserName = "user13@mail.com",
     NormalizedUserName = "USER13@MAIL.COM",
     Email = "user13@mail.com",
     NormalizedEmail = "USER13@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp13",
     ConcurrencyStamp = "stamp13"
 },

 new IdentityUser
 {
     Id = "u14",
     UserName = "user14@mail.com",
     NormalizedUserName = "USER14@MAIL.COM",
     Email = "user14@mail.com",
     NormalizedEmail = "USER14@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp14",
     ConcurrencyStamp = "stamp14"
 },

 new IdentityUser
 {
     Id = "u15",
     UserName = "user15@mail.com",
     NormalizedUserName = "USER15@MAIL.COM",
     Email = "user15@mail.com",
     NormalizedEmail = "USER15@MAIL.COM",
     EmailConfirmed = true,
     PasswordHash = "AQAAAAEAACcQAAAAEMockHash",
     SecurityStamp = "stamp15",
     ConcurrencyStamp = "stamp15"
 }

 );
        }
    }
}
    
    


