export interface AdhanTimesDTO {
    code: number;
    status: string;
    data: {
      timings: {
        Fajr: string;
        Dhuhr: string;
        Asr: string;
        Maghrib: string;
        Isha: string;
        Sunrise: string;
        Sunset: string;
      };
      date: {
        readable: string;
        timestamp: string;
        hijri: {
          date: string;
          format: string;
          day: string;
          weekday: {
            en: string;
          };
          month: {
            en: string;
          };
          year: string;
          designation: {
            abbreviated: string;
            expanded: string;
          };
        };
        gregorian: {
          date: string;
          format: string;
          day: string;
          weekday: {
            en: string;
          };
          month: {
            en: string;
          };
          year: string;
        };
      };
      meta: {
        latitude: number;
        longitude: number;
        timezone: string;
        method: {
          id: number;
          name: string;
          params: {
            Fajr: number;
            Isha: number;
          };
        };
        latitudeAdjustmentMethod: string;
        midnightMode: string;
        school: string;
        offset: {
          Imsak: number;
          Fajr: number;
          Sunrise: number;
          Dhuhr: number;
          Asr: number;
          Maghrib: number;
          Sunset: number;
          Isha: number;
          Midnight: number;
        };
      };
    };
  }
  