open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful

let game =
    choose [
        GET >=>  OK (view.index)
    ]

startWebServer defaultConfig game