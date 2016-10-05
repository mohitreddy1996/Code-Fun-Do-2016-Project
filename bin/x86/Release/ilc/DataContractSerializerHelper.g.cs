using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
        }
        static int[] s_knownContractsLists = new int[] {
              -1,   45,   46,   47,   53,   75,   76,   77,   42,   78, 
              -1,   45,   46,   47,   53,   75,   76,   77,   42,   78, 
              -1,   46,   47,   45,   53,   75,   76,   77,   42,   78, 
              -1,   46,   47,   45,   53,   75,   76,   77,   42,   78, 
              -1,   46,   47,   45,   53,   75,   76,   77,   42,   78, 
              -1,   48,   -1,   48,   -1,   45,   46,   47,   53,   75, 
              76,   77,   42,   78,   -1,   45,   46,   47,   53,   75, 
              76,   77,   42,   78,   -1,   45,   46,   47,   53,   75, 
              76,   77,   42,   78,   -1,   45,   46,   47,   53,   75, 
              76,   77,   42,   78,   -1,   45,   46,   47,   53,   75, 
              76,   77,   42,   78,   -1, }
        ;
        // Count = 729
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                8, // array length: 8
                1545, // index: 1545, string: "authenticationResultCode"
                1570, // index: 1570, string: "brandLogoUri"
                1583, // index: 1583, string: "copyright"
                1593, // index: 1593, string: "errorDetails"
                1606, // index: 1606, string: "resourceSets"
                1619, // index: 1619, string: "statusCode"
                1630, // index: 1630, string: "statusDescription"
                1648, // index: 1648, string: "traceId"
                8, // array length: 8
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                -1, // string: null
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                1656, // index: 1656, string: "estimatedTotal"
                1671, // index: 1671, string: "resources"
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                9, // array length: 9
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                -1, // string: null
                -1, // string: null
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                9, // array length: 9
                1681, // index: 1681, string: "__type"
                1688, // index: 1688, string: "bbox"
                1693, // index: 1693, string: "address"
                1701, // index: 1701, string: "confidence"
                1712, // index: 1712, string: "entityType"
                1723, // index: 1723, string: "geocodePoints"
                1737, // index: 1737, string: "matchCodes"
                1748, // index: 1748, string: "name"
                1753, // index: 1753, string: "point"
                9, // array length: 9
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                2, // array length: 2
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                1681, // index: 1681, string: "__type"
                1688, // index: 1688, string: "bbox"
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                10, // array length: 10
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                10, // array length: 10
                1681, // index: 1681, string: "__type"
                1688, // index: 1688, string: "bbox"
                1759, // index: 1759, string: "imageHeight"
                1771, // index: 1771, string: "imageUrl"
                1780, // index: 1780, string: "imageUrlSubdomains"
                1799, // index: 1799, string: "imageWidth"
                1810, // index: 1810, string: "vintageEnd"
                1821, // index: 1821, string: "vintageStart"
                1834, // index: 1834, string: "zoomMax"
                1842, // index: 1842, string: "zoomMin"
                10, // array length: 10
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                13, // array length: 13
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                3, // array length: 3
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                13, // array length: 13
                1681, // index: 1681, string: "__type"
                1688, // index: 1688, string: "bbox"
                1759, // index: 1759, string: "imageHeight"
                1771, // index: 1771, string: "imageUrl"
                1780, // index: 1780, string: "imageUrlSubdomains"
                1799, // index: 1799, string: "imageWidth"
                1810, // index: 1810, string: "vintageEnd"
                1821, // index: 1821, string: "vintageStart"
                1834, // index: 1834, string: "zoomMax"
                1842, // index: 1842, string: "zoomMin"
                1850, // index: 1850, string: "orientation"
                1862, // index: 1862, string: "tilesX"
                1869, // index: 1869, string: "tilesY"
                13, // array length: 13
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                13, // array length: 13
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                -1, // string: null
                -1, // string: null
                3, // array length: 3
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                13, // array length: 13
                1681, // index: 1681, string: "__type"
                1688, // index: 1688, string: "bbox"
                1759, // index: 1759, string: "imageHeight"
                1771, // index: 1771, string: "imageUrl"
                1780, // index: 1780, string: "imageUrlSubdomains"
                1799, // index: 1799, string: "imageWidth"
                1810, // index: 1810, string: "vintageEnd"
                1821, // index: 1821, string: "vintageStart"
                1834, // index: 1834, string: "zoomMax"
                1842, // index: 1842, string: "zoomMin"
                1876, // index: 1876, string: "mapCenter"
                1886, // index: 1886, string: "pushpins"
                1895, // index: 1895, string: "zoom"
                13, // array length: 13
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                5, // array length: 5
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                5, // array length: 5
                1900, // index: 1900, string: "boundingBox"
                1912, // index: 1912, string: "calculationMethod"
                1930, // index: 1930, string: "coordinates"
                1942, // index: 1942, string: "type"
                1947, // index: 1947, string: "usageTypes"
                5, // array length: 5
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                1, // array length: 1
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                1, // array length: 1
                1900, // index: 1900, string: "boundingBox"
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                -1, // string: null
                1, // array length: 1
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                4, // array length: 4
                1958, // index: 1958, string: "anchor"
                1965, // index: 1965, string: "bottomRightOffset"
                1753, // index: 1753, string: "point"
                1983, // index: 1983, string: "topLeftOffset"
                4, // array length: 4
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                2, // array length: 2
                1997, // index: 1997, string: "x"
                1999, // index: 1999, string: "y"
                2, // array length: 2
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                9, // array length: 9
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                9, // array length: 9
                1681, // index: 1681, string: "__type"
                1688, // index: 1688, string: "bbox"
                2001, // index: 2001, string: "distanceUnit"
                2014, // index: 2014, string: "durationUnit"
                2027, // index: 2027, string: "id"
                2030, // index: 2030, string: "routeLegs"
                2040, // index: 2040, string: "routePath"
                2050, // index: 2050, string: "travelDistance"
                2065, // index: 2065, string: "travelDuration"
                9, // array length: 9
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                -1, // string: null
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                7, // array length: 7
                2080, // index: 2080, string: "actualEnd"
                2090, // index: 2090, string: "actualStart"
                2102, // index: 2102, string: "endLocation"
                2114, // index: 2114, string: "itineraryItems"
                2129, // index: 2129, string: "startLocation"
                2050, // index: 2050, string: "travelDistance"
                2065, // index: 2065, string: "travelDuration"
                7, // array length: 7
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                20, // array length: 20
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                20, // array length: 20
                2143, // index: 2143, string: "childItineraryItems"
                2163, // index: 2163, string: "compassDirection"
                2180, // index: 2180, string: "details"
                2188, // index: 2188, string: "exit"
                2193, // index: 2193, string: "hints"
                2199, // index: 2199, string: "iconType"
                2208, // index: 2208, string: "instruction"
                2220, // index: 2220, string: "maneuverPoint"
                2234, // index: 2234, string: "sideOfStreet"
                2247, // index: 2247, string: "signs"
                2253, // index: 2253, string: "time"
                2258, // index: 2258, string: "tollZone"
                2267, // index: 2267, string: "towardsRoadName"
                2283, // index: 2283, string: "transitLine"
                2295, // index: 2295, string: "transitStopId"
                2309, // index: 2309, string: "transitTerminus"
                2050, // index: 2050, string: "travelDistance"
                2065, // index: 2065, string: "travelDuration"
                2325, // index: 2325, string: "travelMode"
                2336, // index: 2336, string: "warning"
                20, // array length: 20
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                9, // array length: 9
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                9, // array length: 9
                2344, // index: 2344, string: "compassDegrees"
                2359, // index: 2359, string: "endPathIndices"
                2374, // index: 2374, string: "locationCodes"
                2388, // index: 2388, string: "maneuverType"
                2401, // index: 2401, string: "mode"
                2406, // index: 2406, string: "names"
                2412, // index: 2412, string: "roadShieldRequestParameters"
                2440, // index: 2440, string: "roadType"
                2449, // index: 2449, string: "startPathIndices"
                9, // array length: 9
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                2466, // index: 2466, string: "bucket"
                2473, // index: 2473, string: "shields"
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                2481, // index: 2481, string: "labels"
                2488, // index: 2488, string: "roadShieldType"
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                2503, // index: 2503, string: "hintType"
                2512, // index: 2512, string: "text"
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                2388, // index: 2388, string: "maneuverType"
                2512, // index: 2512, string: "text"
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                9, // array length: 9
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                9, // array length: 9
                2517, // index: 2517, string: "abbreviatedName"
                2533, // index: 2533, string: "agencyId"
                2542, // index: 2542, string: "agencyName"
                2553, // index: 2553, string: "lineColor"
                2563, // index: 2563, string: "lineTextColor"
                2577, // index: 2577, string: "phoneNumber"
                2589, // index: 2589, string: "providerInfo"
                2602, // index: 2602, string: "uri"
                2606, // index: 2606, string: "verboseName"
                9, // array length: 9
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                3, // array length: 3
                2618, // index: 2618, string: "severity"
                2512, // index: 2512, string: "text"
                2627, // index: 2627, string: "warningType"
                3, // array length: 3
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                2639, // index: 2639, string: "generalizations"
                2655, // index: 2655, string: "line"
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                2660, // index: 2660, string: "latLongTolerance"
                2677, // index: 2677, string: "pathIndices"
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                1, // array length: 1
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                2, // array length: 2
                1930, // index: 1930, string: "coordinates"
                1942, // index: 1942, string: "type"
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                17, // array length: 17
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                17, // array length: 17
                1681, // index: 1681, string: "__type"
                1688, // index: 1688, string: "bbox"
                2689, // index: 2689, string: "congestion"
                2700, // index: 2700, string: "description"
                2712, // index: 2712, string: "detour"
                2719, // index: 2719, string: "end"
                2723, // index: 2723, string: "incidentId"
                2734, // index: 2734, string: "lane"
                2739, // index: 2739, string: "lastModified"
                2374, // index: 2374, string: "locationCodes"
                1753, // index: 1753, string: "point"
                2752, // index: 2752, string: "roadClosed"
                2618, // index: 2618, string: "severity"
                2763, // index: 2763, string: "start"
                2769, // index: 2769, string: "toPoint"
                1942, // index: 1942, string: "type"
                2777, // index: 2777, string: "verified"
                17, // array length: 17
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                3, // array length: 3
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                3, // array length: 3
                1681, // index: 1681, string: "__type"
                1688, // index: 1688, string: "bbox"
                2786, // index: 2786, string: "value"
                3, // array length: 3
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                4, // array length: 4
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                4, // array length: 4
                1681, // index: 1681, string: "__type"
                1688, // index: 1688, string: "bbox"
                2792, // index: 2792, string: "elevations"
                2803, // index: 2803, string: "zoomLevel"
                4, // array length: 4
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                4, // array length: 4
                -1, // string: null
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                328, // index: 328, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                2, // array length: 2
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                4, // array length: 4
                1681, // index: 1681, string: "__type"
                1688, // index: 1688, string: "bbox"
                2813, // index: 2813, string: "offsets"
                2803, // index: 2803, string: "zoomLevel"
                4, // array length: 4
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                471, // index: 471, string: "http://schemas.microsoft.com/search/local/ws/rest/v1"
                9, // array length: 9
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                9, // array length: 9
                2821, // index: 2821, string: "addressLine"
                2833, // index: 2833, string: "adminDistrict"
                2847, // index: 2847, string: "adminDistrict2"
                2862, // index: 2862, string: "countryRegion"
                2876, // index: 2876, string: "locality"
                2885, // index: 2885, string: "postalCode"
                2896, // index: 2896, string: "formattedAddress"
                2913, // index: 2913, string: "landmark"
                2922, // index: 2922, string: "neighborhood"
                9, // array length: 9
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                264, // index: 264, string: "http://schemas.datacontract.org/2004/07/Bing.Maps"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                6, // array length: 6
                2821, // index: 2821, string: "addressLine"
                2833, // index: 2833, string: "adminDistrict"
                2847, // index: 2847, string: "adminDistrict2"
                2862, // index: 2862, string: "countryRegion"
                2876, // index: 2876, string: "locality"
                2885, // index: 2885, string: "postalCode"
                6, // array length: 6
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                998, // index: 998, string: "http://schemas.datacontract.org/2004/07/Bing.Core"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                1063, // index: 1063, string: ""
                1, // array length: 1
                1061, // index: 1061, string: "d"
                1, // array length: 1
                1063, // index: 1063, string: ""
                1, // array length: 1
                1093, // index: 1093, string: "http://schemas.datacontract.org/2004/07/Bing.Spatial"
                1, // array length: 1
                1063, // index: 1063, string: ""
                1, // array length: 1
                1061, // index: 1061, string: "d"
                1, // array length: 1
                1063  // index: 1063, string: ""
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_dataContractMap_Hashtable = new byte[0];
        // Count=85
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.MapsResponse`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=" +
                                "null]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Bing.Maps.ResourceSet`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ResourceSet`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=n" +
                                "ull]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, Public" +
                                "KeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Resource, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ImageryMetadata, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.BirdseyeMetadata, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.StaticMapMetadata, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Point, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Shape, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.PinInfo[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.PinInfo, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Pixel, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Route, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RouteLeg[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 82, // 0x52
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RouteLeg, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ItineraryItem[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 98, // 0x62
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ItineraryItem, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Detail[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 114, // 0x72
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Detail, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 130, // 0x82
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RoadShield, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Shield[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 146, // 0x92
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Shield, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Hint[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 162, // 0xa2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Hint, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Instruction, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 289, // 0x121
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.TransitLine, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 305, // 0x131
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Warning[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 178, // 0xb2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Warning, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 321, // 0x141
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RoutePath, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 337, // 0x151
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Generalization[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 194, // 0xc2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Generalization, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 353, // 0x161
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Line, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 369, // 0x171
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double[][], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 210, // 0xd2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.TrafficIncident, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 385, // 0x181
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.CompressedPointList, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 401, // 0x191
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ElevationData, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 417, // 0x1a1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.SeaLevelData, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 433, // 0x1b1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Address, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 449, // 0x1c1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Core.AddressBase, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 465, // 0x1d1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Point[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 226, // 0xe2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Spatial.SpatialResponseWrapper`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, " +
                                "PublicKeyToken=b03f5f7f11d50a3a]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 481, // 0x1e1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Spatial.SpatialResponseListWrapper`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutr" +
                                "al, PublicKeyToken=b03f5f7f11d50a3a]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 497, // 0x1f1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Spatial.SpatialResponseList`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Pub" +
                                "licKeyToken=b03f5f7f11d50a3a]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 336, // 0x150
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_dataContracts_Hashtable = new byte[0];
        // Count=22
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1064, // SpatialResponseListOfanyType
                        NamespaceIndex = 1093, // http://schemas.datacontract.org/2004/07/Bing.Spatial
                        StableNameIndex = 1064, // SpatialResponseListOfanyType
                        StableNameNamespaceIndex = 1093, // http://schemas.datacontract.org/2004/07/Bing.Spatial
                        TopLevelElementNameIndex = 1064, // SpatialResponseListOfanyType
                        TopLevelElementNamespaceIndex = 1093, // http://schemas.datacontract.org/2004/07/Bing.Spatial
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Spatial.SpatialResponseList`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=b03f5f7f11d50a3a]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Spatial.SpatialResponseList`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=b03f5f7f11d50a3a]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Spatial.SpatialResponseList`1, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ErrorMessageIndex = 1146, // Type 'Bing.Spatial.SpatialResponseList`1[System.Object]' cannot be serialized. Consider marking it with the DataContractAttribute attribute, and marking all of its members you want serialized with the DataMemberAttribute attribute.  If the type is a collection, consider marking it with the CollectionDataContractAttribute.  See the Microsoft .NET Framework documentation for other supported types.
                    Kind = global::DataContractKind.InvalidDataContract,
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_classDataContracts_Hashtable = new byte[0];
        // Count=32
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // response
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 255, // response
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 255, // response
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.MapsResponse`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.MapsResponse`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.MapsResponse`1, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type0.ReadresponseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type1.WriteresponseToXml),
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 10,
                    MemberNamesListIndex = 12,
                    MemberNamespacesListIndex = 21,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 424, // ResourceSetOfLocationbt0E_S438
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 424, // ResourceSetOfLocationbt0E_S438
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 424, // ResourceSetOfLocationbt0E_S438
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ResourceSet`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=n" +
                                    "ull]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ResourceSet`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=n" +
                                    "ull]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ResourceSet`1, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type8.ReadResourceSetOfLocationbt0E_S438FromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type9.WriteResourceSetOfLocationbt0E_S438ToXml),
                    ChildElementNamespacesListIndex = 30,
                    ContractNamespacesListIndex = 33,
                    MemberNamesListIndex = 35,
                    MemberNamespacesListIndex = 38,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 524, // Location
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 524, // Location
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 524, // Location
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 1,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type13.ReadLocationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type14.WriteLocationToXml),
                    ChildElementNamespacesListIndex = 41,
                    ContractNamespacesListIndex = 51,
                    MemberNamesListIndex = 54,
                    MemberNamespacesListIndex = 64,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 533, // Resource
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 533, // Resource
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 533, // Resource
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Resource, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Resource, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 11,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type15.ReadResourceFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type16.WriteResourceToXml),
                    ChildElementNamespacesListIndex = 74,
                    ContractNamespacesListIndex = 77,
                    MemberNamesListIndex = 79,
                    MemberNamespacesListIndex = 82,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 556, // ImageryMetadata
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 556, // ImageryMetadata
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 556, // ImageryMetadata
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ImageryMetadata, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ImageryMetadata, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 21,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type20.ReadImageryMetadataFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type21.WriteImageryMetadataToXml),
                    ChildElementNamespacesListIndex = 85,
                    ContractNamespacesListIndex = 96,
                    MemberNamesListIndex = 99,
                    MemberNamespacesListIndex = 110,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 572, // BirdseyeMetadata
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 572, // BirdseyeMetadata
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 572, // BirdseyeMetadata
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.BirdseyeMetadata, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.BirdseyeMetadata, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 31,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type22.ReadBirdseyeMetadataFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type23.WriteBirdseyeMetadataToXml),
                    ChildElementNamespacesListIndex = 121,
                    ContractNamespacesListIndex = 135,
                    MemberNamesListIndex = 139,
                    MemberNamespacesListIndex = 153,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 589, // StaticMapMetadata
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 589, // StaticMapMetadata
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 589, // StaticMapMetadata
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.StaticMapMetadata, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.StaticMapMetadata, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 41,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type24.ReadStaticMapMetadataFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type25.WriteStaticMapMetadataToXml),
                    ChildElementNamespacesListIndex = 167,
                    ContractNamespacesListIndex = 181,
                    MemberNamesListIndex = 185,
                    MemberNamespacesListIndex = 199,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 607, // Point
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 607, // Point
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 607, // Point
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Point, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Point, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 51,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type26.ReadPointFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type27.WritePointToXml),
                    ChildElementNamespacesListIndex = 213,
                    ContractNamespacesListIndex = 219,
                    MemberNamesListIndex = 222,
                    MemberNamespacesListIndex = 228,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 613, // Shape
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 613, // Shape
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 613, // Shape
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Shape, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Shape, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 53,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type28.ReadShapeFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type29.WriteShapeToXml),
                    ChildElementNamespacesListIndex = 234,
                    ContractNamespacesListIndex = 236,
                    MemberNamesListIndex = 238,
                    MemberNamespacesListIndex = 240,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 634, // PinInfo
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 634, // PinInfo
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 634, // PinInfo
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.PinInfo, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.PinInfo, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type33.ReadPinInfoFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type34.WritePinInfoToXml),
                    ChildElementNamespacesListIndex = 242,
                    ContractNamespacesListIndex = 247,
                    MemberNamesListIndex = 249,
                    MemberNamespacesListIndex = 254,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 642, // Pixel
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 642, // Pixel
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 642, // Pixel
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Pixel, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Pixel, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type35.ReadPixelFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type36.WritePixelToXml),
                    ChildElementNamespacesListIndex = 259,
                    ContractNamespacesListIndex = 262,
                    MemberNamesListIndex = 264,
                    MemberNamespacesListIndex = 267,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 648, // Route
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 648, // Route
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 648, // Route
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Route, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Route, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 55,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type37.ReadRouteFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type38.WriteRouteToXml),
                    ChildElementNamespacesListIndex = 270,
                    ContractNamespacesListIndex = 280,
                    MemberNamesListIndex = 283,
                    MemberNamespacesListIndex = 293,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 670, // RouteLeg
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 670, // RouteLeg
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 670, // RouteLeg
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RouteLeg, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RouteLeg, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type42.ReadRouteLegFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type43.WriteRouteLegToXml),
                    ChildElementNamespacesListIndex = 303,
                    ContractNamespacesListIndex = 311,
                    MemberNamesListIndex = 313,
                    MemberNamespacesListIndex = 321,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 700, // ItineraryItem
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 700, // ItineraryItem
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 700, // ItineraryItem
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ItineraryItem, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ItineraryItem, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type47.ReadItineraryItemFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type48.WriteItineraryItemToXml),
                    ChildElementNamespacesListIndex = 329,
                    ContractNamespacesListIndex = 350,
                    MemberNamesListIndex = 352,
                    MemberNamespacesListIndex = 373,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 728, // Detail
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 728, // Detail
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 728, // Detail
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Detail, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Detail, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type52.ReadDetailFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type53.WriteDetailToXml),
                    ChildElementNamespacesListIndex = 394,
                    ContractNamespacesListIndex = 404,
                    MemberNamesListIndex = 406,
                    MemberNamespacesListIndex = 416,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 746, // RoadShield
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 746, // RoadShield
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 746, // RoadShield
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RoadShield, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RoadShield, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type57.ReadRoadShieldFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type58.WriteRoadShieldToXml),
                    ChildElementNamespacesListIndex = 426,
                    ContractNamespacesListIndex = 429,
                    MemberNamesListIndex = 431,
                    MemberNamespacesListIndex = 434,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 771, // Shield
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 771, // Shield
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 771, // Shield
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Shield, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Shield, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type62.ReadShieldFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type63.WriteShieldToXml),
                    ChildElementNamespacesListIndex = 437,
                    ContractNamespacesListIndex = 440,
                    MemberNamesListIndex = 442,
                    MemberNamespacesListIndex = 445,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 790, // Hint
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 790, // Hint
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 790, // Hint
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Hint, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Hint, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type67.ReadHintFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type68.WriteHintToXml),
                    ChildElementNamespacesListIndex = 448,
                    ContractNamespacesListIndex = 451,
                    MemberNamesListIndex = 453,
                    MemberNamespacesListIndex = 456,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 795, // Instruction
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 795, // Instruction
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 795, // Instruction
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Instruction, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Instruction, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type69.ReadInstructionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type70.WriteInstructionToXml),
                    ChildElementNamespacesListIndex = 459,
                    ContractNamespacesListIndex = 462,
                    MemberNamesListIndex = 464,
                    MemberNamespacesListIndex = 467,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 807, // TransitLine
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 807, // TransitLine
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 807, // TransitLine
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.TransitLine, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.TransitLine, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type71.ReadTransitLineFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type72.WriteTransitLineToXml),
                    ChildElementNamespacesListIndex = 470,
                    ContractNamespacesListIndex = 480,
                    MemberNamesListIndex = 482,
                    MemberNamespacesListIndex = 492,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 834, // Warning
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 834, // Warning
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 834, // Warning
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Warning, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Warning, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type76.ReadWarningFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type77.WriteWarningToXml),
                    ChildElementNamespacesListIndex = 502,
                    ContractNamespacesListIndex = 506,
                    MemberNamesListIndex = 508,
                    MemberNamespacesListIndex = 512,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 842, // RoutePath
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 842, // RoutePath
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 842, // RoutePath
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RoutePath, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RoutePath, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type78.ReadRoutePathFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type79.WriteRoutePathToXml),
                    ChildElementNamespacesListIndex = 516,
                    ContractNamespacesListIndex = 519,
                    MemberNamesListIndex = 521,
                    MemberNamespacesListIndex = 524,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 874, // Generalization
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 874, // Generalization
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 874, // Generalization
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Generalization, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Generalization, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type83.ReadGeneralizationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type84.WriteGeneralizationToXml),
                    ChildElementNamespacesListIndex = 527,
                    ContractNamespacesListIndex = 530,
                    MemberNamesListIndex = 532,
                    MemberNamespacesListIndex = 535,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 889, // Line
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 889, // Line
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 889, // Line
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Line, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Line, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type85.ReadLineFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type86.WriteLineToXml),
                    ChildElementNamespacesListIndex = 538,
                    ContractNamespacesListIndex = 541,
                    MemberNamesListIndex = 543,
                    MemberNamespacesListIndex = 546,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 915, // TrafficIncident
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 915, // TrafficIncident
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 915, // TrafficIncident
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.TrafficIncident, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.TrafficIncident, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 65,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type90.ReadTrafficIncidentFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type91.WriteTrafficIncidentToXml),
                    ChildElementNamespacesListIndex = 549,
                    ContractNamespacesListIndex = 567,
                    MemberNamesListIndex = 570,
                    MemberNamespacesListIndex = 588,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 931, // CompressedPointList
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 931, // CompressedPointList
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 931, // CompressedPointList
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.CompressedPointList, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.CompressedPointList, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 75,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type92.ReadCompressedPointListFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type93.WriteCompressedPointListToXml),
                    ChildElementNamespacesListIndex = 606,
                    ContractNamespacesListIndex = 610,
                    MemberNamesListIndex = 613,
                    MemberNamespacesListIndex = 617,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 951, // ElevationData
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 951, // ElevationData
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 951, // ElevationData
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ElevationData, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ElevationData, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 85,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type94.ReadElevationDataFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type95.WriteElevationDataToXml),
                    ChildElementNamespacesListIndex = 621,
                    ContractNamespacesListIndex = 626,
                    MemberNamesListIndex = 629,
                    MemberNamespacesListIndex = 634,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 965, // SeaLevelData
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 965, // SeaLevelData
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 965, // SeaLevelData
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.SeaLevelData, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.SeaLevelData, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 95,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type96.ReadSeaLevelDataFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type97.WriteSeaLevelDataToXml),
                    ChildElementNamespacesListIndex = 639,
                    ContractNamespacesListIndex = 644,
                    MemberNamesListIndex = 647,
                    MemberNamespacesListIndex = 652,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 978, // Address
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 978, // Address
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 978, // Address
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Address, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Address, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type98.ReadAddressFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type99.WriteAddressToXml),
                    ChildElementNamespacesListIndex = 657,
                    ContractNamespacesListIndex = 667,
                    MemberNamesListIndex = 670,
                    MemberNamespacesListIndex = 680,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 986, // AddressBase
                        NamespaceIndex = 998, // http://schemas.datacontract.org/2004/07/Bing.Core
                        StableNameIndex = 986, // AddressBase
                        StableNameNamespaceIndex = 998, // http://schemas.datacontract.org/2004/07/Bing.Core
                        TopLevelElementNameIndex = 986, // AddressBase
                        TopLevelElementNamespaceIndex = 998, // http://schemas.datacontract.org/2004/07/Bing.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Core.AddressBase, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Core.AddressBase, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type100.ReadAddressBaseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type101.WriteAddressBaseToXml),
                    ChildElementNamespacesListIndex = 690,
                    ContractNamespacesListIndex = 697,
                    MemberNamesListIndex = 699,
                    MemberNamespacesListIndex = 706,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1061, // d
                        NamespaceIndex = 1063, // 
                        StableNameIndex = 1061, // d
                        StableNameNamespaceIndex = 1063, // 
                        TopLevelElementNameIndex = 1061, // d
                        TopLevelElementNamespaceIndex = 1063, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Spatial.SpatialResponseWrapper`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=b03f5f7f11d50a3a]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Spatial.SpatialResponseWrapper`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=b03f5f7f11d50a3a]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Spatial.SpatialResponseWrapper`1, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type105.ReaddFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type106.WritedToXml),
                    ChildElementNamespacesListIndex = 713,
                    ContractNamespacesListIndex = 715,
                    MemberNamesListIndex = 717,
                    MemberNamespacesListIndex = 719,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1061, // d
                        NamespaceIndex = 1063, // 
                        StableNameIndex = 1061, // d
                        StableNameNamespaceIndex = 1063, // 
                        TopLevelElementNameIndex = 1061, // d
                        TopLevelElementNamespaceIndex = 1063, // 
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Spatial.SpatialResponseListWrapper`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutr" +
                                    "al, PublicKeyToken=b03f5f7f11d50a3a]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Spatial.SpatialResponseListWrapper`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutr" +
                                    "al, PublicKeyToken=b03f5f7f11d50a3a]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Spatial.SpatialResponseListWrapper`1, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type107.ReaddFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type108.WritedToXml),
                    ChildElementNamespacesListIndex = 721,
                    ContractNamespacesListIndex = 723,
                    MemberNamesListIndex = 725,
                    MemberNamespacesListIndex = 727,
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_collectionDataContracts_Hashtable = new byte[0];
        // Count=15
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 314, // ArrayOfstring
                        NamespaceIndex = 328, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 314, // ArrayOfstring
                        StableNameNamespaceIndex = 328, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 314, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 328, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type2.ReadArrayOfstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type3.WriteArrayOfstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type4.ReadArrayOfstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 386, // ArrayOfResourceSetOfLocationbt0E_S438
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 386, // ArrayOfResourceSetOfLocationbt0E_S438
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 386, // ArrayOfResourceSetOfLocationbt0E_S438
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Bing.Maps.ResourceSet`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Bing.Maps.ResourceSet`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type5.ReadArrayOfResourceSetOfLocationbt0E_S438FromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type6.WriteArrayOfResourceSetOfLocationbt0E_S438ToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type7.ReadArrayOfResourceSetOfLocationbt0E_S438FromXmlIsGetOnly),
                    CollectionItemNameIndex = 424, // ResourceSetOfLocationbt0E_S438
                    KeyNameIndex = -1,
                    ItemNameIndex = 424, // ResourceSetOfLocationbt0E_S438
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ResourceSet`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=n" +
                                "ull]], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 455, // ArrayOfLocation
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 455, // ArrayOfLocation
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 455, // ArrayOfLocation
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, Public" +
                                    "KeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, Public" +
                                    "KeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type10.ReadArrayOfLocationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type11.WriteArrayOfLocationToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type12.ReadArrayOfLocationFromXmlIsGetOnly),
                    CollectionItemNameIndex = 524, // Location
                    KeyNameIndex = -1,
                    ItemNameIndex = 524, // Location
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Location, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 542, // ArrayOfdouble
                        NamespaceIndex = 328, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 542, // ArrayOfdouble
                        StableNameNamespaceIndex = 328, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 542, // ArrayOfdouble
                        TopLevelElementNamespaceIndex = 328, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type17.ReadArrayOfdoubleFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type18.WriteArrayOfdoubleToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type19.ReadArrayOfdoubleFromXmlIsGetOnly),
                    CollectionItemNameIndex = 128, // double
                    KeyNameIndex = -1,
                    ItemNameIndex = 128, // double
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 619, // ArrayOfPinInfo
                        NamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        StableNameIndex = 619, // ArrayOfPinInfo
                        StableNameNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        TopLevelElementNameIndex = 619, // ArrayOfPinInfo
                        TopLevelElementNamespaceIndex = 471, // http://schemas.microsoft.com/search/local/ws/rest/v1
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.PinInfo[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.PinInfo[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type30.ReadArrayOfPinInfoFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type31.WriteArrayOfPinInfoToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type32.ReadArrayOfPinInfoFromXmlIsGetOnly),
                    CollectionItemNameIndex = 634, // PinInfo
                    KeyNameIndex = -1,
                    ItemNameIndex = 634, // PinInfo
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.PinInfo, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 654, // ArrayOfRouteLeg
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 654, // ArrayOfRouteLeg
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 654, // ArrayOfRouteLeg
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RouteLeg[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RouteLeg[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type39.ReadArrayOfRouteLegFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type40.WriteArrayOfRouteLegToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type41.ReadArrayOfRouteLegFromXmlIsGetOnly),
                    CollectionItemNameIndex = 670, // RouteLeg
                    KeyNameIndex = -1,
                    ItemNameIndex = 670, // RouteLeg
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.RouteLeg, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 679, // ArrayOfItineraryItem
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 679, // ArrayOfItineraryItem
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 679, // ArrayOfItineraryItem
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ItineraryItem[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ItineraryItem[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type44.ReadArrayOfItineraryItemFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type45.WriteArrayOfItineraryItemToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type46.ReadArrayOfItineraryItemFromXmlIsGetOnly),
                    CollectionItemNameIndex = 700, // ItineraryItem
                    KeyNameIndex = -1,
                    ItemNameIndex = 700, // ItineraryItem
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.ItineraryItem, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 714, // ArrayOfDetail
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 714, // ArrayOfDetail
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 714, // ArrayOfDetail
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Detail[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Detail[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type49.ReadArrayOfDetailFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type50.WriteArrayOfDetailToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type51.ReadArrayOfDetailFromXmlIsGetOnly),
                    CollectionItemNameIndex = 728, // Detail
                    KeyNameIndex = -1,
                    ItemNameIndex = 728, // Detail
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Detail, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 735, // ArrayOfint
                        NamespaceIndex = 328, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 735, // ArrayOfint
                        StableNameNamespaceIndex = 328, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 735, // ArrayOfint
                        TopLevelElementNamespaceIndex = 328, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type54.ReadArrayOfintFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type55.WriteArrayOfintToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type56.ReadArrayOfintFromXmlIsGetOnly),
                    CollectionItemNameIndex = 146, // int
                    KeyNameIndex = -1,
                    ItemNameIndex = 146, // int
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 757, // ArrayOfShield
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 757, // ArrayOfShield
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 757, // ArrayOfShield
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Shield[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Shield[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type59.ReadArrayOfShieldFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type60.WriteArrayOfShieldToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type61.ReadArrayOfShieldFromXmlIsGetOnly),
                    CollectionItemNameIndex = 771, // Shield
                    KeyNameIndex = -1,
                    ItemNameIndex = 771, // Shield
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Shield, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 778, // ArrayOfHint
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 778, // ArrayOfHint
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 778, // ArrayOfHint
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Hint[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Hint[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type64.ReadArrayOfHintFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type65.WriteArrayOfHintToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type66.ReadArrayOfHintFromXmlIsGetOnly),
                    CollectionItemNameIndex = 790, // Hint
                    KeyNameIndex = -1,
                    ItemNameIndex = 790, // Hint
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Hint, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 819, // ArrayOfWarning
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 819, // ArrayOfWarning
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 819, // ArrayOfWarning
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Warning[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Warning[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type73.ReadArrayOfWarningFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type74.WriteArrayOfWarningToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type75.ReadArrayOfWarningFromXmlIsGetOnly),
                    CollectionItemNameIndex = 834, // Warning
                    KeyNameIndex = -1,
                    ItemNameIndex = 834, // Warning
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Warning, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 852, // ArrayOfGeneralization
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 852, // ArrayOfGeneralization
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 852, // ArrayOfGeneralization
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Generalization[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Generalization[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type80.ReadArrayOfGeneralizationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type81.WriteArrayOfGeneralizationToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type82.ReadArrayOfGeneralizationFromXmlIsGetOnly),
                    CollectionItemNameIndex = 874, // Generalization
                    KeyNameIndex = -1,
                    ItemNameIndex = 874, // Generalization
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Generalization, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 894, // ArrayOfArrayOfdouble
                        NamespaceIndex = 328, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 894, // ArrayOfArrayOfdouble
                        StableNameNamespaceIndex = 328, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 894, // ArrayOfArrayOfdouble
                        TopLevelElementNamespaceIndex = 328, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double[][], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double[][], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type87.ReadArrayOfArrayOfdoubleFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type88.WriteArrayOfArrayOfdoubleToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type89.ReadArrayOfArrayOfdoubleFromXmlIsGetOnly),
                    CollectionItemNameIndex = 542, // ArrayOfdouble
                    KeyNameIndex = -1,
                    ItemNameIndex = 542, // ArrayOfdouble
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1048, // ArrayOfPoint
                        NamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        StableNameIndex = 1048, // ArrayOfPoint
                        StableNameNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        TopLevelElementNameIndex = 1048, // ArrayOfPoint
                        TopLevelElementNamespaceIndex = 264, // http://schemas.datacontract.org/2004/07/Bing.Maps
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Point[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Point[], Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type102.ReadArrayOfPointFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type103.WriteArrayOfPointToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type104.ReadArrayOfPointFromXmlIsGetOnly),
                    CollectionItemNameIndex = 607, // Point
                    KeyNameIndex = -1,
                    ItemNameIndex = 607, // Point
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Bing.Maps.Point, Bing.RestClient, Version=0.6.0.0, Culture=neutral, PublicKeyToken=null")),
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_enumDataContracts_Hashtable = new byte[0];
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_xmlDataContracts_Hashtable = new byte[0];
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','r','e','s','p','o','n','s','e','\0','h','t','t','p',':','/',
            '/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4',
            '/','0','7','/','B','i','n','g','.','M','a','p','s','\0','A','r','r','a','y','O','f','s','t','r','i','n','g','\0','h','t',
            't','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','2','0','0',
            '3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o','n','/','A','r','r','a','y','s','\0','A','r','r','a',
            'y','O','f','R','e','s','o','u','r','c','e','S','e','t','O','f','L','o','c','a','t','i','o','n','b','t','0','E','_','S',
            '4','3','8','\0','R','e','s','o','u','r','c','e','S','e','t','O','f','L','o','c','a','t','i','o','n','b','t','0','E','_',
            'S','4','3','8','\0','A','r','r','a','y','O','f','L','o','c','a','t','i','o','n','\0','h','t','t','p',':','/','/','s','c',
            'h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','s','e','a','r','c','h','/','l','o','c',
            'a','l','/','w','s','/','r','e','s','t','/','v','1','\0','L','o','c','a','t','i','o','n','\0','R','e','s','o','u','r','c',
            'e','\0','A','r','r','a','y','O','f','d','o','u','b','l','e','\0','I','m','a','g','e','r','y','M','e','t','a','d','a','t',
            'a','\0','B','i','r','d','s','e','y','e','M','e','t','a','d','a','t','a','\0','S','t','a','t','i','c','M','a','p','M','e',
            't','a','d','a','t','a','\0','P','o','i','n','t','\0','S','h','a','p','e','\0','A','r','r','a','y','O','f','P','i','n','I',
            'n','f','o','\0','P','i','n','I','n','f','o','\0','P','i','x','e','l','\0','R','o','u','t','e','\0','A','r','r','a','y','O',
            'f','R','o','u','t','e','L','e','g','\0','R','o','u','t','e','L','e','g','\0','A','r','r','a','y','O','f','I','t','i','n',
            'e','r','a','r','y','I','t','e','m','\0','I','t','i','n','e','r','a','r','y','I','t','e','m','\0','A','r','r','a','y','O',
            'f','D','e','t','a','i','l','\0','D','e','t','a','i','l','\0','A','r','r','a','y','O','f','i','n','t','\0','R','o','a','d',
            'S','h','i','e','l','d','\0','A','r','r','a','y','O','f','S','h','i','e','l','d','\0','S','h','i','e','l','d','\0','A','r',
            'r','a','y','O','f','H','i','n','t','\0','H','i','n','t','\0','I','n','s','t','r','u','c','t','i','o','n','\0','T','r','a',
            'n','s','i','t','L','i','n','e','\0','A','r','r','a','y','O','f','W','a','r','n','i','n','g','\0','W','a','r','n','i','n',
            'g','\0','R','o','u','t','e','P','a','t','h','\0','A','r','r','a','y','O','f','G','e','n','e','r','a','l','i','z','a','t',
            'i','o','n','\0','G','e','n','e','r','a','l','i','z','a','t','i','o','n','\0','L','i','n','e','\0','A','r','r','a','y','O',
            'f','A','r','r','a','y','O','f','d','o','u','b','l','e','\0','T','r','a','f','f','i','c','I','n','c','i','d','e','n','t',
            '\0','C','o','m','p','r','e','s','s','e','d','P','o','i','n','t','L','i','s','t','\0','E','l','e','v','a','t','i','o','n',
            'D','a','t','a','\0','S','e','a','L','e','v','e','l','D','a','t','a','\0','A','d','d','r','e','s','s','\0','A','d','d','r',
            'e','s','s','B','a','s','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n',
            't','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','B','i','n','g','.','C','o','r','e','\0','A','r',
            'r','a','y','O','f','P','o','i','n','t','\0','d','\0','\0','S','p','a','t','i','a','l','R','e','s','p','o','n','s','e','L',
            'i','s','t','O','f','a','n','y','T','y','p','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a',
            't','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','B','i','n','g','.','S','p',
            'a','t','i','a','l','\0','T','y','p','e',' ','\'','B','i','n','g','.','S','p','a','t','i','a','l','.','S','p','a','t','i',
            'a','l','R','e','s','p','o','n','s','e','L','i','s','t','`','1','[','S','y','s','t','e','m','.','O','b','j','e','c','t',
            ']','\'',' ','c','a','n','n','o','t',' ','b','e',' ','s','e','r','i','a','l','i','z','e','d','.',' ','C','o','n','s','i',
            'd','e','r',' ','m','a','r','k','i','n','g',' ','i','t',' ','w','i','t','h',' ','t','h','e',' ','D','a','t','a','C','o',
            'n','t','r','a','c','t','A','t','t','r','i','b','u','t','e',' ','a','t','t','r','i','b','u','t','e',',',' ','a','n','d',
            ' ','m','a','r','k','i','n','g',' ','a','l','l',' ','o','f',' ','i','t','s',' ','m','e','m','b','e','r','s',' ','y','o',
            'u',' ','w','a','n','t',' ','s','e','r','i','a','l','i','z','e','d',' ','w','i','t','h',' ','t','h','e',' ','D','a','t',
            'a','M','e','m','b','e','r','A','t','t','r','i','b','u','t','e',' ','a','t','t','r','i','b','u','t','e','.',' ',' ','I',
            'f',' ','t','h','e',' ','t','y','p','e',' ','i','s',' ','a',' ','c','o','l','l','e','c','t','i','o','n',',',' ','c','o',
            'n','s','i','d','e','r',' ','m','a','r','k','i','n','g',' ','i','t',' ','w','i','t','h',' ','t','h','e',' ','C','o','l',
            'l','e','c','t','i','o','n','D','a','t','a','C','o','n','t','r','a','c','t','A','t','t','r','i','b','u','t','e','.',' ',
            ' ','S','e','e',' ','t','h','e',' ','M','i','c','r','o','s','o','f','t',' ','.','N','E','T',' ','F','r','a','m','e','w',
            'o','r','k',' ','d','o','c','u','m','e','n','t','a','t','i','o','n',' ','f','o','r',' ','o','t','h','e','r',' ','s','u',
            'p','p','o','r','t','e','d',' ','t','y','p','e','s','.','\0','a','u','t','h','e','n','t','i','c','a','t','i','o','n','R',
            'e','s','u','l','t','C','o','d','e','\0','b','r','a','n','d','L','o','g','o','U','r','i','\0','c','o','p','y','r','i','g',
            'h','t','\0','e','r','r','o','r','D','e','t','a','i','l','s','\0','r','e','s','o','u','r','c','e','S','e','t','s','\0','s',
            't','a','t','u','s','C','o','d','e','\0','s','t','a','t','u','s','D','e','s','c','r','i','p','t','i','o','n','\0','t','r',
            'a','c','e','I','d','\0','e','s','t','i','m','a','t','e','d','T','o','t','a','l','\0','r','e','s','o','u','r','c','e','s',
            '\0','_','_','t','y','p','e','\0','b','b','o','x','\0','a','d','d','r','e','s','s','\0','c','o','n','f','i','d','e','n','c',
            'e','\0','e','n','t','i','t','y','T','y','p','e','\0','g','e','o','c','o','d','e','P','o','i','n','t','s','\0','m','a','t',
            'c','h','C','o','d','e','s','\0','n','a','m','e','\0','p','o','i','n','t','\0','i','m','a','g','e','H','e','i','g','h','t',
            '\0','i','m','a','g','e','U','r','l','\0','i','m','a','g','e','U','r','l','S','u','b','d','o','m','a','i','n','s','\0','i',
            'm','a','g','e','W','i','d','t','h','\0','v','i','n','t','a','g','e','E','n','d','\0','v','i','n','t','a','g','e','S','t',
            'a','r','t','\0','z','o','o','m','M','a','x','\0','z','o','o','m','M','i','n','\0','o','r','i','e','n','t','a','t','i','o',
            'n','\0','t','i','l','e','s','X','\0','t','i','l','e','s','Y','\0','m','a','p','C','e','n','t','e','r','\0','p','u','s','h',
            'p','i','n','s','\0','z','o','o','m','\0','b','o','u','n','d','i','n','g','B','o','x','\0','c','a','l','c','u','l','a','t',
            'i','o','n','M','e','t','h','o','d','\0','c','o','o','r','d','i','n','a','t','e','s','\0','t','y','p','e','\0','u','s','a',
            'g','e','T','y','p','e','s','\0','a','n','c','h','o','r','\0','b','o','t','t','o','m','R','i','g','h','t','O','f','f','s',
            'e','t','\0','t','o','p','L','e','f','t','O','f','f','s','e','t','\0','x','\0','y','\0','d','i','s','t','a','n','c','e','U',
            'n','i','t','\0','d','u','r','a','t','i','o','n','U','n','i','t','\0','i','d','\0','r','o','u','t','e','L','e','g','s','\0',
            'r','o','u','t','e','P','a','t','h','\0','t','r','a','v','e','l','D','i','s','t','a','n','c','e','\0','t','r','a','v','e',
            'l','D','u','r','a','t','i','o','n','\0','a','c','t','u','a','l','E','n','d','\0','a','c','t','u','a','l','S','t','a','r',
            't','\0','e','n','d','L','o','c','a','t','i','o','n','\0','i','t','i','n','e','r','a','r','y','I','t','e','m','s','\0','s',
            't','a','r','t','L','o','c','a','t','i','o','n','\0','c','h','i','l','d','I','t','i','n','e','r','a','r','y','I','t','e',
            'm','s','\0','c','o','m','p','a','s','s','D','i','r','e','c','t','i','o','n','\0','d','e','t','a','i','l','s','\0','e','x',
            'i','t','\0','h','i','n','t','s','\0','i','c','o','n','T','y','p','e','\0','i','n','s','t','r','u','c','t','i','o','n','\0',
            'm','a','n','e','u','v','e','r','P','o','i','n','t','\0','s','i','d','e','O','f','S','t','r','e','e','t','\0','s','i','g',
            'n','s','\0','t','i','m','e','\0','t','o','l','l','Z','o','n','e','\0','t','o','w','a','r','d','s','R','o','a','d','N','a',
            'm','e','\0','t','r','a','n','s','i','t','L','i','n','e','\0','t','r','a','n','s','i','t','S','t','o','p','I','d','\0','t',
            'r','a','n','s','i','t','T','e','r','m','i','n','u','s','\0','t','r','a','v','e','l','M','o','d','e','\0','w','a','r','n',
            'i','n','g','\0','c','o','m','p','a','s','s','D','e','g','r','e','e','s','\0','e','n','d','P','a','t','h','I','n','d','i',
            'c','e','s','\0','l','o','c','a','t','i','o','n','C','o','d','e','s','\0','m','a','n','e','u','v','e','r','T','y','p','e',
            '\0','m','o','d','e','\0','n','a','m','e','s','\0','r','o','a','d','S','h','i','e','l','d','R','e','q','u','e','s','t','P',
            'a','r','a','m','e','t','e','r','s','\0','r','o','a','d','T','y','p','e','\0','s','t','a','r','t','P','a','t','h','I','n',
            'd','i','c','e','s','\0','b','u','c','k','e','t','\0','s','h','i','e','l','d','s','\0','l','a','b','e','l','s','\0','r','o',
            'a','d','S','h','i','e','l','d','T','y','p','e','\0','h','i','n','t','T','y','p','e','\0','t','e','x','t','\0','a','b','b',
            'r','e','v','i','a','t','e','d','N','a','m','e','\0','a','g','e','n','c','y','I','d','\0','a','g','e','n','c','y','N','a',
            'm','e','\0','l','i','n','e','C','o','l','o','r','\0','l','i','n','e','T','e','x','t','C','o','l','o','r','\0','p','h','o',
            'n','e','N','u','m','b','e','r','\0','p','r','o','v','i','d','e','r','I','n','f','o','\0','u','r','i','\0','v','e','r','b',
            'o','s','e','N','a','m','e','\0','s','e','v','e','r','i','t','y','\0','w','a','r','n','i','n','g','T','y','p','e','\0','g',
            'e','n','e','r','a','l','i','z','a','t','i','o','n','s','\0','l','i','n','e','\0','l','a','t','L','o','n','g','T','o','l',
            'e','r','a','n','c','e','\0','p','a','t','h','I','n','d','i','c','e','s','\0','c','o','n','g','e','s','t','i','o','n','\0',
            'd','e','s','c','r','i','p','t','i','o','n','\0','d','e','t','o','u','r','\0','e','n','d','\0','i','n','c','i','d','e','n',
            't','I','d','\0','l','a','n','e','\0','l','a','s','t','M','o','d','i','f','i','e','d','\0','r','o','a','d','C','l','o','s',
            'e','d','\0','s','t','a','r','t','\0','t','o','P','o','i','n','t','\0','v','e','r','i','f','i','e','d','\0','v','a','l','u',
            'e','\0','e','l','e','v','a','t','i','o','n','s','\0','z','o','o','m','L','e','v','e','l','\0','o','f','f','s','e','t','s',
            '\0','a','d','d','r','e','s','s','L','i','n','e','\0','a','d','m','i','n','D','i','s','t','r','i','c','t','\0','a','d','m',
            'i','n','D','i','s','t','r','i','c','t','2','\0','c','o','u','n','t','r','y','R','e','g','i','o','n','\0','l','o','c','a',
            'l','i','t','y','\0','p','o','s','t','a','l','C','o','d','e','\0','f','o','r','m','a','t','t','e','d','A','d','d','r','e',
            's','s','\0','l','a','n','d','m','a','r','k','\0','n','e','i','g','h','b','o','r','h','o','o','d','\0'};
    }
}
