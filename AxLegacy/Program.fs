open AMovie

[<EntryPoint>]
let main argv = 
    let a = ActiveMovieClass()
    printfn "Current volume: %d" a.Volume
    0 // return an integer exit code
