using System;

namespace FinalProjectV0._1
{
    public class SessionNote
    {
        public SessionNote()
        {

        }

        public SessionNote(string volunteerName, string noteDescription, string noteTitle, DateTime datePosted, string group)
        {
            this.volunteerName = volunteerName;
            this.noteDescription = noteDescription;
            this.noteTitle = noteTitle;
            this.datePosted = datePosted;
            this.group = group;
        }
        public void SetSessionNote(string volunteerName, string noteDescription, string noteTitle, DateTime datePosted, string group)
        {
            this.volunteerName = volunteerName;
            this.noteDescription = noteDescription;
            this.noteTitle = noteTitle;
            this.datePosted = datePosted;
            this.group = group;
        }

        public string volunteerName { get; set; }
        public string noteDescription { get; set; }
        public string noteTitle { get; set; }
        public DateTime datePosted { get; set; }
        public string group { get; set; }
    }
}