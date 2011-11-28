module Helper

[<Measure>] type radian
[<Measure>] type degree
[<Measure>] type km

type LatLong = { Lat : float<degree>; Long : float<degree> }

let radians_to_degrees (r : float<radian>) =  r / System.Math.PI * 180.0<degree/radian> 

let degrees_to_radians (d : float<degree>) =  d * System.Math.PI / 180.0<degree/radian> 

let SphereSurfaceDistance<[<Measure>] 't>
    (radius : float<'t>) (loc1 : LatLong) (loc2 : LatLong) =    
    
    // Convert latitude and longitude to    
    // spherical coordinates in radians.    
    //let degrees_to_radians (d : float<degree>) =  d * System.Math.PI / 180.0<degree/radian>     
    
    // phi = 90 - latitude (coded F# pipeline style)    
    let phi1 = (90.0<degree> - loc1.Lat) |> degrees_to_radians
    let phi2 = (90.0<degree> - loc2.Lat) |> degrees_to_radians

    // theta = longitude (coded F# function call style)    
    let theta1 = degrees_to_radians loc1.Long
    let theta2 = degrees_to_radians loc2.Long
    
    // Compute spherical distance from spherical coordinates.  
    // For two locations in spherical coordinates   
    // (1, theta, phi) and (1, theta, phi)
    // cosine( arc length ) = sin phi sin phi' cos(theta-theta') + cos phi cos phi'
    // distance = rho * arc length
    radius * acos(sin(float(phi1)) * sin(float(phi2)) * cos(float(theta1 - theta2)) + cos(float(phi1)) * cos(float(phi2))) 

// instantiate Earth-relative functions in km
let SurfaceDistanceOnEarthKm = SphereSurfaceDistance 6376.5<km>
//Measure