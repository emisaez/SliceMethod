# SliceMethod
JavaScript equivalent string slice method in C#


string simpleText = "¡Hello, World from CSharp!";
            
var r = simpleText.Slice(-4, -1); // arp
var r2 = simpleText.Slice(-4); // arp!
var r3 = simpleText.Slice(0); // ¡Hello, World from CSharp!
var r4 = simpleText.Slice(-20); // , World from CSharp!
