jQuery(document).ready(function() {

    jQuery( function ( $ ) {

        $( "#nd_booking_archive_form_date_range_from" ).datepicker({
          defaultDate: "+1w",
          minDate: 0,
          altField: "#nd_booking_date_month_from",
          altFormat: "M",
          firstDay: 0,
          dateFormat: "dd/mm/yy",
          monthNames: ["Ocak","Subat","Mart","Nisan","Mayýs","Haziran", "Temmuz","Aðustos","Eylül","Ekim","Kasým","Aralýk"],
          monthNamesShort: [ "Ock", "Sub", "Mar", "Nis", "May", "Haz", "Tem", "Agu", "Eyl", "Ekm", "Ksm", "Ara" ],
          dayNamesMin: ["PAZ","PZT","SAL","ÇRÞ","PER","CU", "CMT"],
          nextText: "NEXT",
          prevText: "PREV",
          changeMonth: false,
          numberOfMonths: 1,
          onClose: function() {   
            var minDate = $(this).datepicker("getDate");
            var newMin = new Date(minDate.setDate(minDate.getDate() + 1));
            $( "#nd_booking_archive_form_date_range_to" ).datepicker( "option", "minDate", newMin );

            var nd_booking_input_date_from = $( "#nd_booking_archive_form_date_range_from" ).val();
            var nd_booking_date_number_from = nd_booking_input_date_from.substring(3, 5);
            $( "#nd_booking_date_number_from" ).val(nd_booking_date_number_from);
            var nd_booking_input_date_to = $( "#nd_booking_archive_form_date_range_to" ).val();
            var nd_booking_date_number_to = nd_booking_input_date_to.substring(3, 5);
            $( "#nd_booking_date_number_to" ).val(nd_booking_date_number_to);

            $( "#nd_booking_date_number_from_front" ).text(nd_booking_date_number_from);
            var nd_booking_date_month_from = $( "#nd_booking_date_month_from" ).val();
            $( "#nd_booking_date_month_from_front" ).text(nd_booking_date_month_from);

            $( "#nd_booking_date_number_to_front" ).text(nd_booking_date_number_to);
            var nd_booking_date_month_to = $( "#nd_booking_date_month_to" ).val();
            $( "#nd_booking_date_month_to_front" ).text(nd_booking_date_month_to);
          }
        });
        

        $( "#nd_booking_archive_form_date_range_to" ).datepicker({
          defaultDate: "+1w",
          altField: "#nd_booking_date_month_to",
          altFormat: "M",
          minDate: "+1d",
            monthNames: ["Ocak", "Subat", "Mart", "Nisan", "Mayýs", "Haziran", "Temmuz", "Aðustos", "Eylül", "Ekim", "Kasým", "Aralýk"],
            monthNamesShort: ["Ock", "Sub", "Mar", "Nis", "May", "Haz", "Tem", "Agu", "Eyl", "Ekm", "Ksm", "Ara" ],
            dayNamesMin: ["PAZ", "PZT", "SAL", "ÇRÞ", "PER", "CU", "CMT"],
          nextText: "Sonraki",
          prevText: "Önceki",
          changeMonth: false,
          firstDay: 0,
          dateFormat: "dd/mm/yy",
          numberOfMonths: 1,
          onClose: function() {   
            
            var nd_booking_input_date_from = $( "#nd_booking_archive_form_date_range_from" ).val();
            var nd_booking_date_number_from = nd_booking_input_date_from.substring(3, 5);
            $( "#nd_booking_date_number_from" ).val(nd_booking_date_number_from);
            var nd_booking_input_date_to = $( "#nd_booking_archive_form_date_range_to" ).val();
            var nd_booking_date_number_to = nd_booking_input_date_to.substring(3, 5);
            $( "#nd_booking_date_number_to" ).val(nd_booking_date_number_to);

            $( "#nd_booking_date_number_from_front" ).text(nd_booking_date_number_from);
            var nd_booking_date_month_from = $( "#nd_booking_date_month_from" ).val();
            $( "#nd_booking_date_month_from_front" ).text(nd_booking_date_month_from);

            $( "#nd_booking_date_number_to_front" ).text(nd_booking_date_number_to);
            var nd_booking_date_month_to = $( "#nd_booking_date_month_to" ).val();
            $( "#nd_booking_date_month_to_front" ).text(nd_booking_date_month_to);

          }
        });
        
        $("#nd_booking_archive_form_date_range_from").datepicker("setDate", "+0");
        $("#nd_booking_archive_form_date_range_to").datepicker("setDate", "+1");
   
        function nd_booking_get_nights(){
          var nd_booking_archive_form_date_range_from = $("#nd_booking_archive_form_date_range_from").val();
          var nd_booking_archive_form_date_range_to = $("#nd_booking_archive_form_date_range_to").val();
          var nd_booking_start = new Date(nd_booking_archive_form_date_range_from);
          var nd_booking_end = new Date(nd_booking_archive_form_date_range_to);
          var nd_booking_nights_number = (nd_booking_end - nd_booking_start) / 1000 / 60 / 60 / 24; 
          $( ".nd_booking_nights_number" ).text(nd_booking_nights_number); 
        }

        $("#nd_booking_open_calendar_from").click(function () {
            $("#nd_booking_archive_form_date_range_from").datepicker("show");
        });
        $("#nd_booking_open_calendar_to").click(function () {
            $("#nd_booking_archive_form_date_range_to").datepicker("show");
        });

    });

    jQuery( function ( $ ) {

        $(".nd_booking_guests_increase").click(function() {
          var value = $(".nd_booking_guests_number").text();
          value++;
          $(".nd_booking_guests_number").text(value);
          $("#nd_booking_archive_form_guests").val(value);

          if ( value > 1 ) {
            $(".nd_booking_guests_number_word").text("GUESTS");  
          }


        }); 

        $(".nd_booking_guests_decrease").click(function() {
          var value = $(".nd_booking_guests_number").text();
          
          if ( value > 1 ) {
            value--;
            $(".nd_booking_guests_number").text(value);
            $("#nd_booking_archive_form_guests").val(value);
          }

          if ( value == 1 ) {
            $(".nd_booking_guests_number_word").text("GUEST");  
          }
          
        }); 
        
      });

});