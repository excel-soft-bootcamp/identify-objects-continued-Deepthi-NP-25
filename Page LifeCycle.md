  # Page life cycle in asp.net:
  - When an ASP.NET page runs, the page goes through a life cycle in which it performs a series of processing steps. These include:-
  - initialization, instantiating controls, restoring and maintaining state, running event handler code, and rendering.
 
  
    |Stages of an asp.net page|    |     |       |
    |--------------|-------------------------|------------------|----------|
    |Page request|starting of page life cycle|Page initialization|Page load|
    |Validation|Postback event handling|Page rendering|Unload|
     
   - At each stage of the page life cycle, the page raises some events, which could be coded. 
   - An event handler is basically a function or subroutine, bound to the event, using declarative attributes such as Onclick or handle.
   
   |Page life cycle events|   |   |   |   |   |
   |----------------------|--|--|--|--|--|
   |PreInit|Init|InitComplete|LoadView State|Load Post Data|Pre Load|
   |Load|Load Complete|PreRender|PreRender Complete|SaveState Complete|UnLoad|
