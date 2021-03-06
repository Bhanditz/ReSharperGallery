using System;
using System.Collections.Generic;
using System.Linq;

namespace NuGetGallery
{
    public interface ICuratedFeedService
    {
        CuratedPackage CreatedCuratedPackage(
            CuratedFeed curatedFeed,
            Package package,
            bool included = false,
            bool automaticallyCurated = false,
            string notes = null,
            bool commitChanges = true);

        void DeleteCuratedPackage(
            int curatedFeedKey,
            int curatedPackageKey);

        void ModifyCuratedPackage(
            int curatedFeedKey,
            int curatedPackageKey,
            bool included);

        CuratedFeed GetFeedByName(string name, bool includePackages);
        CuratedFeed GetFeedByKey(int key, bool includePackages);
        IEnumerable<CuratedFeed> GetFeedsForManager(int managerKey);
        IQueryable<Package> GetPackages(string curatedFeedName);
        IQueryable<CuratedPackage> GetCuratedPackageRegistrations(string curatedFeedName);
        IQueryable<PackageRegistration> GetPackageRegistrations(string curatedFeedName);
        int? GetKey(string curatedFeedName);
        void UpdateIsLatest(PackageRegistration packageRegistration, bool commitChanges);
    }
}
