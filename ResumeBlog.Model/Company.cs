namespace ResumeBlog.Model
{
    public class Company
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public UserIdentity User { get; set; }

        public string CompanyName { get; set; }

        public string WebSite { get; set; }

        public string CityTown { get; set; }

        public string RegionState { get; set; }

        public string Country { get; set; }


        //TODO: Extend this model(through remove field OfferDetails and adding additional tables)
        //TODO: something like auction system,- for recruiters.
        public string OfferDetails { get; set; }

    }
}