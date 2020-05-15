open System 

let data = Console.ReadLine() 
let mutable max = 5 
let mutable scope = 19 
let columns = 100 

let mutable i = 1 
let mutable j = 1 

let dash() = 
    while i <= columns do 
        printf "_" 

        i <- i + 1
    done
    printfn ""


let body() = 
    while max > 0 do 
        let rows = (( ** ) (2 |> double) ((5 - max) |> double) |> int) 
        i <- 1 

        while i <= rows do 
            j <- 1
            while j <= 100 do 
                let left = (j - scope) % (4 * rows) - (i - 1)
                let right = (j - scope + (2 * rows) + i - 1) % (4 * rows) 

                if max <= (data |> int) && (j - scope) >= 0 && (j + scope) <= columns then 
                    if left = 0 || right = 0 then 
                        printf "1"
                    else
                        printf "_"
                else 
                    printf "_"

                j <- j + 1 
            done

            i <- i + 1
            printfn "" 
        done

        i <- 1 

        while i <= rows do 
            j <- 1 
            while j <= columns do 
                let m = (j - scope + (3 * rows)) % (4 * rows) 

                if max <= (data |> int) && (j - scope) >= 0 && (j + scope) <= columns && m = 0 then 
                    printf "1"
                else 
                    printf "_"

                j <- j + 1 
            done
            i <- i + 1 
            printfn ""
        done
        max <- max - 1 
        scope <- scope + rows 
    done 

dash() 
body() 
