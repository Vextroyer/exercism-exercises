use time::PlainDateTime as DateTime;
use time::Duration as Duration;

// Returns a DateTime one billion seconds after start.
pub fn after(start: DateTime) -> DateTime {
    let oneBillionSeconds = Duration::new(1000000000,0);
    return start + oneBillionSeconds;
}
