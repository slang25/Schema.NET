namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See Organization, Place for more information.
    /// </summary>
    [DataContract]
    public abstract partial class OrganizationAndPlace : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrganizationAndPlace";

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;/p&gt;
        /// &lt;p&gt;Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 106)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<PropertyValue>? AdditionalProperty { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<PostalAddress, string>? Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<AggregateRating>? AggregateRating { get; set; }

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Person>? Alumni { get; set; }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<LocationFeatureSpecification>? AmenityFeature { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<AdministrativeArea, GeoShape, Place, string>? AreaServed { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 112)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? Award { get; set; }

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;/p&gt;
        /// &lt;p&gt;For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        /// </summary>
        [DataMember(Name = "branchCode", Order = 113)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? BranchCode { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 114)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Brand, Organization>? Brand { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 115)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<ContactPoint>? ContactPoint { get; set; }

        /// <summary>
        /// The basic containment relation between a place and one that contains it.
        /// </summary>
        [DataMember(Name = "containedInPlace", Order = 116)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? ContainedInPlace { get; set; }

        /// <summary>
        /// The basic containment relation between a place and another that it contains.
        /// </summary>
        [DataMember(Name = "containsPlace", Order = 117)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? ContainsPlace { get; set; }

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [DataMember(Name = "department", Order = 118)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization>? Department { get; set; }

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        [DataMember(Name = "dissolutionDate", Order = 119)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<DateTimeOffset?>? DissolutionDate { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 120)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 121)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? Email { get; set; }

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        [DataMember(Name = "employee", Order = 122)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Person>? Employee { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 123)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Event>? Event { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 124)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        [DataMember(Name = "founder", Order = 125)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Person>? Founder { get; set; }

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        [DataMember(Name = "foundingDate", Order = 126)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<DateTimeOffset?>? FoundingDate { get; set; }

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        [DataMember(Name = "foundingLocation", Order = 127)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? FoundingLocation { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 128)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization, Person>? Funder { get; set; }

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [DataMember(Name = "geo", Order = 129)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<GeoCoordinates, GeoShape>? Geo { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyContains", Order = 130)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyContains { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCoveredBy", Order = 131)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyCoveredBy { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCovers", Order = 132)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyCovers { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCrosses", Order = 133)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyCrosses { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
        /// </summary>
        [DataMember(Name = "geospatiallyDisjoint", Order = 134)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyDisjoint { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
        /// </summary>
        [DataMember(Name = "geospatiallyEquals", Order = 135)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyEquals { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyIntersects", Order = 136)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyIntersects { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyOverlaps", Order = 137)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyOverlaps { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
        /// </summary>
        [DataMember(Name = "geospatiallyTouches", Order = 138)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyTouches { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyWithin", Order = 139)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? GeospatiallyWithin { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 140)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? GlobalLocationNumber { get; set; }

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [DataMember(Name = "hasMap", Order = 141)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Map, Uri>? HasMap { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 142)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<OfferCatalog>? HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 143)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place>? HasPOS { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 144)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? IsicV4 { get; set; }

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        [DataMember(Name = "legalName", Order = 145)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? LegalName { get; set; }

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [DataMember(Name = "leiCode", Order = 146)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? LeiCode { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 147)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place, PostalAddress, string>? Location { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 148)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<ImageObject, Uri>? Logo { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 149)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Offer>? MakesOffer { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 150)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<int?>? MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 151)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization, Person>? Member { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 152)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization, ProgramMembership>? MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 153)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? Naics { get; set; }

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 154)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<QuantitativeValue>? NumberOfEmployees { get; set; }

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        [DataMember(Name = "openingHoursSpecification", Order = 155)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<OpeningHoursSpecification>? OpeningHoursSpecification { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 156)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<OwnershipInfo, Product>? Owns { get; set; }

        /// <summary>
        /// The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        [DataMember(Name = "parentOrganization", Order = 157)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization>? ParentOrganization { get; set; }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [DataMember(Name = "photo", Order = 158)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<ImageObject, Photograph>? Photo { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 159)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Review>? Review { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 160)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Demand>? Seeks { get; set; }

        /// <summary>
        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        /// </summary>
        [DataMember(Name = "smokingAllowed", Order = 161)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<bool?>? SmokingAllowed { get; set; }

        /// <summary>
        /// The special opening hours of a certain place.&lt;/p&gt;
        /// &lt;p&gt;Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "specialOpeningHoursSpecification", Order = 162)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<OpeningHoursSpecification>? SpecialOpeningHoursSpecification { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 163)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization, Person>? Sponsor { get; set; }

        /// <summary>
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        [DataMember(Name = "subOrganization", Order = 164)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization>? SubOrganization { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 165)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 166)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 167)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string>? VatID { get; set; }
    }
}
