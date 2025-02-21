namespace ApiProjectCamp.WebApi.Dtos.MessageDtos
{
    public class ResultMessageDto
    {
        public int MessageID { get; set; }
        public string MessageNameSurname { get; set; }
        public string MessageEmail { get; set; }
        public string MessageSubject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime MessagesendDate { get; set; }
        public bool MessageIsRead { get; set; }
    }
}
