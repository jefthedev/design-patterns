![Behavioral - Iterator](https://user-images.githubusercontent.com/60556559/160283691-ff32e83a-f364-4a97-983d-f0b08527dfca.png)

<p>Iterator provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.</p>

<h2>Uses</h2>
<p>Use when:</p>
<ul>
	<li>You need to access the elements of an aggregate object sequentially.</li>
</ul>

<h2>Pros</h2>
<ul>
	<li>Decouples the object's official intent from the way its iteration is performed.</li>
	<li>Allows you to traverse the aggregate in different ways depending on your needs.</li>
	<li>Don't need to bloat your class with operations for different traversals.</li>
	<li>It encapsulates the internal structure of how the iterator occurs.</li>
    <li>The same iterator can be used for different aggregates.</li>
	<li>It's possible to pause the iteration process.</li>
</ul>
<h2>Cons</h2>
<ul>
	<li>Not thread safe unless its a robust iterator that allows insertions and deletions. This can be solved by letting the iterator use a <b>Memento<b> to capture the state of an iteration.</li>
	<li>Usually usefull only if your collection has a complex traverse process.</li>
</ul>
<br>
<br>
<b>Source:</b> GoF