module Tests

open System
open Xunit

[<Theory>]
[<InlineData("123", 123)>] // "123" -> 123
[<InlineData("a1b2c3", 123)>] // "a1b2c3" -> 123
[<InlineData("1a2b3c", 123)>] // "1a2b3c" -> 123
[<InlineData("1a2b3c4", 1234)>] // "1a2b3c4" -> 1234
[<InlineData("1a2b3c4d5", 12345)>] // "1a2b3c4d5" -> 12345
let ``filter the Number working fine`` (s: String, expected: int) =
    let actual = SevenKyu.filterTheNumber s
    Assert.Equal(expected, actual)
    let actual2 = SevenKyu.filterTheNumber2 s
    Assert.Equal(expected, actual2)