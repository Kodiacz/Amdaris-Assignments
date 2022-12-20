namespace PetCare.Api.Extensions
{
    using Microsoft.AspNetCore.Mvc.Filters;

    public static class PetClinicFilterCollectionExtension
    {
        public static FilterCollection AddApplicationFilters(this FilterCollection filterCollection)
        {
            filterCollection.Add(typeof(ExceptionHandler));

            return filterCollection;
        }
    }
}
