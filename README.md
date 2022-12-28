# ByBrickCompetitionApp

## Description
Project used in a competition by ByBrick during christmas/new years 2022. The original sourcecode were to be optimized as seen fit.


## Enhancement ideas / thought of process
Due to the uncertainty in what the exact rules are, I chose to aim initially on quick enhancements without changing the overall pattern. Firstly, changing the declaration of the `StreamWriter` used for output as well as skipping the `Flush()` per iteration gave a substantial performance gain. Normally, I'd probably stop there depending on whether the performance needed yet more boosting.

In order to try to gain more performance, just to see if it is possible, I firstly tried different buffersizes on the output stream, since it can give a boost by writing larger blocks. This is of course dependent on quite a number of parameters. 64k seemed to give me the best gain with -20ms on average compared to the default setting.

Next up, but also requiring changes to the classes used, is to parallelize the loop. This can be done in a number of ways. `Parallel.ForEach` and `Parallel.For` gave about the same result, so I opted for the easier to read ForEach. Splitting the work array based on the object type beforehand and iterating over them without checking for the type on each iteration also gave no measureable performance gain but only added complexity to the code. When parallelizing the main loop I also changed the classes to use `Random.Shared` in order to have threadsafe random numbers. This parallelizing change also required to handle concurrent use of the StreamWriters. Simply wrapping them with a `lock()` gave no performance gain, so I opted for wrapping the StreamWriter in a `TextWriter.Synchronized`.

Any touch-ups with style, naming etc has been left out.

### Additional tests
Any subsequent short attempts to enhance the performance did not give enough of a boost to be worth it. Among the tested implementations are:
* Cache the calculated value using a ConcurrentDictionary. Gives a 5-10ms performance increase at best, and only applicable for circles due to the estimated amount of unique values.
* Change the classes to structs. Gives a 5ms performance increase at best.
* Change the random number generator from Random.Shared. No performance increase.

## Conclusion
Based on the information and code provided in the case, I believe that the short and easy implemented fixes are good enough, giving about a 1000x performance boost. Any additional fixes will most likely make the code more complex and harder to maintain, while still maybe being suboptimal due to other factors that are out of reach such as disk speed etc.

If there were additional information for the assignment, I could possibly find other optimizations to do: Buffering the output differently. Creating a better pseudo-random number generator by creating a large byte array and pick random numbers on the go from this. Writing a better cache for already calculated values. Pre-calculate values. And so on. But still, the performance gains based on the small amount of work I put in is good enough based on the information provided in the case.

## Commits and performance gains
The average run time after specific commits as follows:
* **2e32711** Initial commit - **174s**
* **542d951** Move StreamWriter declaration out from loop. - **1.6s**
* **5056cbf** Remove StreamWriter Flush() - **281ms**
* **ac7e302** Set buffersize on StreamWriter to 64k - **260ms**
* **0bc678f** Parallelize main loop - **160ms**
