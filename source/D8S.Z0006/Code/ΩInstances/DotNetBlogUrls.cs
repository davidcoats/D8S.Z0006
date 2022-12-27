using System;


namespace D8S.Z0006
{
    public class DotNetBlogUrls : IDotNetBlogUrls
    {
        #region Infrastructure

        public static IDotNetBlogUrls Instance { get; } = new DotNetBlogUrls();


        private DotNetBlogUrls()
        {
        }

        #endregion
    }
}
