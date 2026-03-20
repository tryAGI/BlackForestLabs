
#nullable enable

namespace BlackForestLabs
{
    public partial interface IBlackForestLabsClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey);
    }
}