/*!
@class com.github.a2g.generator.FileSystem
So this needs to simulate a hierarchical series of folders and the files 
that are in them.  You'd think some type of tree structure would be the apt thing,
but for unit testing purposes.
<br>
But the easiest thing to test was just to keep a list of all the files and folders 
represented by the file system, and iterate through the list to find which ones 
are sub folders and which ones are sub files.
<br>
Some sort of tree structure would be most efficient,  but that would be an optimization
task to begin when it's too slow. As it is probably the first optimization to try is to not 
iterate through the entire list of folder entries, but to iterate through just the items
that are one level deeper than the requested files. Since all the entries are sorted this
shouldn't be too hard.
<br>
 */
