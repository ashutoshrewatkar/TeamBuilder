# TeamBuilder
This application provides team building  events in locations across Ireland.

## Description
TeamBuilder Ltd, a company that provides team building events in locations across Ireland. The purpose of the application is to enable the companies front of 
house sales team to generate quotations and process bookings for these events.

## Basic flow of events
* When the application loads, the user is asked to enter a password before being able to view any details or pricing of the workshops. The password is ‘NUIGalway@07’. 
* On entering the correct password, the user can select an event from a ListBox control and an event location from another (each booking must contain an event and a location). The user can also select a 
meal option, and whether the attendee wishes to receive a printed certificate on the completion of the event. 
* When the user clicks the ‘Display’ button, the application displays all of the details of the chosen event along with registration cost, the lodging cost, the optional costs and overall workshop
cost in an appropriate control.
* If the prospective client wishes to proceed, the user clicks the ‘Book’ button, after which a Message Box with a formatted message confirming the completion of the booking is displayed. This 
confirmation message contains the name and location of the event booked along with total cost.
