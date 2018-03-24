////toastr.options = {
////    "closeButton": false,
////    "debug": false,
////    "newestOnTop": false,
////    "progressBar": true,
////    "positionClass": "toast-top-right",
////    "preventDuplicates": true,
////    "onclick": null,
////    "showDuration": "300",
////    "hideDuration": "1000",
////    "timeOut": "2000",
////    "extendedTimeOut": "1000",
////    "showEasing": "swing",
////    "hideEasing": "linear",
////    "showMethod": "fadeIn",
////    "hideMethod": "fadeOut"
////}

//function AjaxModal() {
//    $(document).ready(function () {
//        $(function () {
//            $.ajaxSetup({ cache: false });

//            $("a[data-modal]").on("click",
//                function (e) {
//                    $('#myModalContent').load(this.href,
//                        function () {
//                            $('#myModal').modal({
//                                    keyboard: true
//                                },
//                                'show');
//                            bindForm(this);
//                        });
//                    return false;
//                });
//        });

//        function bindForm(dialog) {
//            $('form', dialog).submit(function () {
//                $.ajax({
//                    url: this.action,
//                    type: this.method,
//                    data: $(this).serialize(),
//                    success: function (result) {
//                        if (result.success) {
//                            $('#myModal').modal('hide');
//                            $('#AddressTarget').load(result.url);
//                        } else {
//                            $('#myModalContent').html(result);
//                            bindForm(dialog);
//                        }
//                    }
//                });
//                return false;
//            });
//        }
//    });
//}

//AjaxModal();




//Institution Details Modal
        $(document).ready(function() {
            $(".btnDetails").click(function () {

                var id = $(this).data("value");

                $("#myModalContent").load("/Institution/Details/" + id,
                    function () {
                        $("#myModal").modal("show");
                    }
                );
            });
        });

