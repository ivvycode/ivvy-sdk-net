using System.Threading.Tasks;

namespace Ivvy
{
    public partial class Api
    {
        /// <summary>
        /// Returns a specific venue.
        /// </summary>
        public async Task<ResultOrError<Venue.Venue>> GetVenueAsync(
            int id)
        {
            return await this.CallAsync<Venue.Venue>(
                "venue", "getVenue", new { id = id }
            );
        }
    }
}