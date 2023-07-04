namespace ch3_dotnet7.Models
{
    public static class Repository()
    {
        private static List<GuestResponse> responses = new();
        public static IEnumerable<GuestResponse> Responses => responses;
        public static void AddResponses(GuestResponse response)
        {
            System.Console.WriteLine(response);
            responses.Add(response);
        }
    }
}