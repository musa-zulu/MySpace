using MyOfficeSpace.Domain.Auth;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyOfficeSpace.Domain.Entities
{
    public class Room : BaseEntity
    {
        [Key]
        public Guid RoomId { get; set; }
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
        
        public ApplicationUser User { get; set; }
    }

    public class Attandee : BaseEntity
    {
        public Guid AttandeeId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    }
    public class Conference : BaseEntity
    {
        public Guid ConferenceId { get; set; }
        public string ConferenceName { get; set; }
    }

    public class ConferenceAttendee : BaseEntity
    {
        public Guid ConferenceId { get; set; }
        public Guid AttendeeId { get; set; }
    }

    public class Session : BaseEntity
    {
        public Guid SessionId { get; set; }
        public string Abstract { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime StartTime { get; set; }
        public string Title { get; set; }
        public Guid ConferenceId { get; set; }
        public Conference Conference { get; set; }
        public Guid TrackId { get; set; }
        public Track Track { get; set; }
    }

    public class Track : BaseEntity
    {
        public Guid TrackId { get; set; }
        public Guid ConferenceId { get; set; }
        public string TrackName { get; set; }
    }

    public class Speaker : BaseEntity
    {
        public Guid SpeakerId { get; set; }
        public string Bio { get; set; }
        public string SpeakerName { get; set; }
        public string Website { get; set; }
        public Guid ConferenceId { get; set; }
        public Conference Conference { get; set; }
    }
    public class SessionSpeaker : BaseEntity 
    {
        public Guid SessionId { get; set;}
        public Guid SpeakerId { get; set; }
    }
    public class SessionAttendee : BaseEntity 
    {
        public Guid SessionId { get; set;}
        public Guid AttendeeId { get; set; }
    }
    public class SessionTag : BaseEntity 
    {
        public Guid SessionId { get; set; }
        public Guid TagId { get; set; }
    }

    public class Tag : BaseEntity 
    {
        public Guid TagId { get; set; }
        public string TagName { get; set; }
    }

}
