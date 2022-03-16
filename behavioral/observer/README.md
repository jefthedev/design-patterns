![Behavioral - Observer](https://user-images.githubusercontent.com/60556559/158512493-16f77ed8-a3c1-4117-ad44-9f3ee56286a3.png)

<p>This is pattern enables publish/subscribe functionality. This is accomplished by an autonomous observable object, which has references to all its observers, that allows other objects (observers) to attach or detach their subscription as they like. The pattern does not impose any limit to the number of observers that can attach, or subscribe, themselves for notification on future changes in the observable's state.</p>

<h2>Uses</h2>
<p>Use when:</p>
<ul>
	<li>An object wants to publish information and many objects will need to receive that information.</li>
</ul>

<h2>Pros</h2>
<ul>
    <li>Loose coupling between observable and observers as the observable does not need to know who or how many subscribers there will be.</li>
	<li>Makes communication between objects at runtime simpler.</li>
</ul>
<h2>Cons</h2>
<ul>
	<li>In a complex scenario there may be problems to determining whether the update to the observable is of relevance to all subscribers or just some of them.</li>
	<li>Sending an update signal to all subscribers might impose a communication overhead of not needed information.</li>
	<li>Can be complicated maintain a specific order of notifications.</li>
</ul>
<br>
<br>
<b>Source:</b> GoF