$(document).ready(function () {
    $('#partsAddButton').on('click', function () {
        var z = 1;
        var partName = $('#PartsName');
        var partPrice = $('#partsPrice');
        var rowCount = parseInt($("#total").val());
        rowCount++;

        $("#total").val(rowCount);

        $('#formRowId').append(
            `
            <div class="col-md-5">
                <div class="form-group">
                    <label class="control-label ">Parts Name ${(rowCount)}</label>
		            <input id="PartsName" name="[${(rowCount)}].PartsName" type="text"  value="" class="form-control" placeholder="Enter parts name">
                </div>
            </div>

            <div class="col-md-5">
	            <div class="form-group">
                    <label class="control-label">Parts Price ${(rowCount)}</label>
    		        <input id="partsPrice" name="[${(rowCount)}].PartsPrice" type="text" class="form-control" value="" placeholder="Enter parts price">
    	        </div>
            </div>

            <div class="col-md-2">
                <div class="input-group-append text-end">
                    <button type="button" id="partsAddButton" class="btn btn-danger d-inline-block update-group mt-4" style="width:fit-content; height:fit-content">
                        Remove
                    </button>
                </div>
            </div>
            `
        );


    });
});

  