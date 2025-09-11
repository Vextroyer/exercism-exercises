// Package weather offers a forecast service.
package weather

// CurrentCondition stores the current weather condition .
var CurrentCondition string
// CurrentLocation sotres the current location where wheather is being forecasted.
var CurrentLocation string

// Forecast gives a forecast as a string for the given city and condition.
func Forecast(city, condition string) string {
	CurrentLocation, CurrentCondition = city, condition
	return CurrentLocation + " - current weather condition: " + CurrentCondition
}
