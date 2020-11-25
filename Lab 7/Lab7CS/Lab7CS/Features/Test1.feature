Feature: Test 1
		Check google page is opening or not after 
		entering https://www.google.co.in in the 
		URL box or not.


@mytag
Scenario:Check google page is opening or not after entering URL
	Given Open Google Chrome Browser
	When Put in the URL box link
	Then Google Chrome are working 