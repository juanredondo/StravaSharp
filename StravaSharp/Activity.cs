﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace StravaSharp
{
    /// <summary>
    /// Type of the activity
    /// </summary>
    public enum ActivityType
    {
        [EnumMember(Value = "ride")]
        Ride,
        [EnumMember(Value = "run")]
        Run,
        [EnumMember(Value = "swim")]
        Swim,
        [EnumMember(Value = "workout")]
        Workout,
        [EnumMember(Value = "hike")]
        Hike,
        [EnumMember(Value = "walk")]
        Walk,
        [EnumMember(Value = "nordicski")]
        NordicSki,
        [EnumMember(Value = "alpineski")]
        AlpineSki,
        [EnumMember(Value = "backcountryski")]
        BackcountrySki,
        [EnumMember(Value = "iceskate")]
        IceSkate,
        [EnumMember(Value = "inlineskate")]
        InlineSkate,
        [EnumMember(Value = "kitesurf")]
        Kitesurf,
        [EnumMember(Value = "rollerski")]
        RollerSki,
        [EnumMember(Value = "windsurf")]
        WindSurf,
        [EnumMember(Value = "snowboard")]
        Snowboard,
        [EnumMember(Value = "snowshoe")]
        SnowShoe
    }

    /// <summary>
    /// Summary representation of an activity
    /// </summary>
    public class ActivitySummary
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }
        /// <summary>
        /// indicates level of detail
        /// </summary>
        [JsonProperty("resource_state")]
        public int ResourceState { get; internal set; }
        /// <summary>
        /// provided at upload
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; internal set; }

        [JsonProperty("upload_id")]
        public int UploadId { get; internal set; }
        [JsonProperty("name")]
        public string Name { get; internal set; }
        //athlete: object
        //meta or summary representation of the athlete
        /// <summary>
        /// Distance [meters]
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; internal set; }
        /// <summary>
        /// Moving time [sec]
        /// </summary>
        [JsonProperty("moving_time")]
        public int MovingTime { get; internal set; }
        /// <summary>
        /// seconds
        /// </summary>
        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; internal set; }
        /// <summary>
        /// meters
        /// </summary>
        [JsonProperty("total_elevation_gain")]
        public float TotalElevationGain { get; internal set; }
        /// <summary>
        /// Activity type, ie.ride, run, swim, etc.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; internal set; }
        //       start_date: time string
        //       start_date_local: time string
        //       timezone: string
        //       start_latlng: [latitude, longitude]
        //        end_latlng: [latitude, longitude]
        //        location_city: string
        //        location_state: string
        //        location_country: string
        //        achievement_count: integer
        //        kudos_count: integer
        //        comment_count: integer
        //        athlete_count: integer
        //         number of athletes taking part in this “group activity”. >= 1 
        //photo_count: integer
        // number of Instagram photos
        //total_photo_count: integer
        // total number of photos(Instagram and Strava)
        //map: object
        // detailed representation of the route
        //trainer: boolean
        //commute: boolean
        //manual: boolean
        //private: boolean
        //flagged: boolean
        //workout_type: integer 
        // for runs only, 0 -> ‘default’, 1 -> ‘race’, 2 -> ‘long run’, 3 -> ‘intervals’ 
        //gear_id: string
        // corresponds to a bike or pair of shoes included in athlete details
        //average_speed: float
        // meters per second
        //max_speed: float
        // meters per second
        //average_cadence: float
        // RPM, if provided at upload
        //average_temp: float
        // degrees Celsius, if provided at upload
        //average_watts: float rides only
        //weighted_average_watts: integer rides with power meter data only
        // similar to xPower or Normalized Power
        //kilojoules: float rides only
        // uses estimated power if necessary
        //device_watts: boolean 
        // true if the watts are from a power meter, false if estimated
        //average_heartrate: float only if recorded with heartrate
        // average over moving portion
        //max_heartrate: integer only if recorded with heartrate
        //has_kudoed: boolean 
        // if the authenticated athlete has kudoed this activity
    }


    public class Activity : ActivitySummary
    {
        [JsonProperty("description")]
        public string Description { get; internal set; }
        //calories: float
        // kilocalories, uses kilojoules for rides and speed/pace for runs

        //gear: object
        //gear summary

        //segment_efforts: array of objects
        // array of summary representations of the segment efforts, segment effort ids must be represented as 64-bit datatypes

        //splits_metric: array of metric split summaries
        // running activities only
        
        //splits_standard: array of standard split summaries
        // running activities only

        //best_efforts: array of best effort summaries
        // running activities only

        //photos: object
        //photos summary
    }
}