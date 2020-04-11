function Transport_UniversityLine(temp) {
    var dataTable = $('#tab_Test1').dataTable();
    if (dataTable) {
        dataTable.fnClearTable(); //清空数据
        dataTable.fnDestroy(); //销毁datatable
    }
    $('#tab_Test1').DataTable({
        "destroy": true,
        "scrollY": 300,//设置垂直滚动条的长度
        "scrollCollapse": true,
        "pagingType": "full_numbers",//显示除首页、上一页、下一页、末页四个按钮还有页数按钮
        "ordering": false,//不允许用户排序
        "info": false,//不展示查询信息
        "bAutoWidth": false,//自适应大小
        "bFilter": false,//是否显示查询框
        "bLengthChange": false,//不允许用户更改每页数据显示条数
        "sProcessing": "处理中...",//数据加载时显示文字
        "language": {
            "sLengthMenu": "每页显示 _MENU_ 条记录",
            "search": "搜索",
            "zeroRecords": "没有找到记录",
            "infoEmpty": "无记录",
            "sInfoFiltered": "(从 _MAX_ 条数据中检索)",
            "oPaginate": {
                "sFirst": "首页",
                "sPrevious": "上一页",
                "sNext": "下一页",
                "sLast": "末页"
            }
        },
        ajax: {
            url: '/Transport/GetUniversityLine',
            dataSrc: '',
            data: {
                "proName": temp[0],
                "batch": temp[1],
                "type": temp[2],
                "year": temp[3],
                "uName": $("#SchoolName").val()
            }
        },
        columns: [
            { data: 'u_name' },
            { data: 'local_province_name' },
            { data: 'type' },
            { data: 'year' },
            { data: 'batch' },
            { data: 'average_score' },
            { data: 'min_score' },
            { data: 'pro_score' }
        ]
    });
}

//按照输入的名字查询大学对各个省份的录取分数线
function Transport_QueryUniversityByName() {
    var dataTable = $('#tab_Test1').dataTable();
    if (dataTable) {
        dataTable.fnClearTable(); //清空数据
        dataTable.fnDestroy(); //销毁datatable
    }
    $('#tab_Test1').DataTable({
        "destroy": true,
        "scrollY": 300,//设置垂直滚动条的长度
        "scrollCollapse": true,
        "pagingType": "full_numbers",//显示除首页、上一页、下一页、末页四个按钮还有页数按钮
        "ordering": false,//不允许用户排序
        "info": false,//不展示查询信息
        "bAutoWidth": false,//自适应大小
        "bFilter": false,//是否显示查询框
        "bLengthChange": false,//不允许用户更改每页数据显示条数
        "sProcessing": "处理中...",//数据加载时显示文字
        "language": {
            "sLengthMenu": "每页显示 _MENU_ 条记录",
            "search": "搜索",
            "zeroRecords": "没有找到记录",
            "infoEmpty": "无记录",
            "sInfoFiltered": "(从 _MAX_ 条数据中检索)",
            "oPaginate": {
                "sFirst": "首页",
                "sPrevious": "上一页",
                "sNext": "下一页",
                "sLast": "末页"
            }
        },
        ajax: {
            url: '/Transport/GetUniversityLineByName',
            dataSrc: '',
            data: {
                "universityName": $("#SchoolName").val()
            }
        },
        columns: [
            { data: 'u_name' },
            { data: 'local_province_name' },
            { data: 'type' },
            { data: 'year' },
            { data: 'batch' },
            { data: 'average_score' },
            { data: 'min_score' },
            { data: 'pro_score' }
        ]
    });
}


function Transport_SpecialLine(temp) {
    var dataTable = $('#tab_Test2').dataTable();
    if (dataTable) {
        dataTable.fnClearTable(); //清空数据
        dataTable.fnDestroy(); //销毁datatable
    }
    //
    $('#tab_Test2').DataTable({
        "destroy": true,
        "scrollY": 300,//设置垂直滚动条的长度
        "scrollCollapse": true,
        "pagingType": "full_numbers",//显示除首页、上一页、下一页、末页四个按钮还有页数按钮
        "ordering": false,//不允许用户排序
        "info": false,//不展示查询信息
        "bAutoWidth": false,//自适应大小
        "bFilter": false,//是否显示查询框
        "bLengthChange": false,//不允许用户更改每页数据显示条数
        "sProcessing": "处理中...",//数据加载时显示文字
        "language": {
            "sLengthMenu": "每页显示 _MENU_ 条记录",
            "search": "搜索",
            "zeroRecords": "没有找到记录",
            "infoEmpty": "无记录",
            "sInfoFiltered": "(从 _MAX_ 条数据中检索)",
            "oPaginate": {
                "sFirst": "首页",
                "sPrevious": "上一页",
                "sNext": "下一页",
                "sLast": "末页"
            }
        },
        ajax: {
            url: '/Transport/GetSpecialLine',
            dataSrc: '',
            data: {
                "proName": temp[0],
                "batch": temp[1],
                "type": temp[2],
                "year": temp[3],
                "specialName": $("#SpecialName").val()
            }
        },
        columns: [
            { data: 'u_name' },
            { data: 'special_name' },
            { data: 'local_province_name' },
            { data: 'type' },
            { data: 'year' },
            { data: 'batch' },
            { data: 'average_score' },
            { data: 'min_score' }
        ]
    });
}

function Transport_QuerySpecialLineByName() {
    var dataTable = $('#tab_Test2').dataTable();
    if (dataTable) {
        dataTable.fnClearTable(); //清空数据
        dataTable.fnDestroy(); //销毁datatable
    }
    $('#tab_Test2').DataTable({
        "destroy": true,
        "scrollY": 300,//设置垂直滚动条的长度
        "scrollCollapse": true,
        "pagingType": "full_numbers",//显示除首页、上一页、下一页、末页四个按钮还有页数按钮
        "ordering": false,//不允许用户排序
        "info": false,//不展示查询信息
        "bAutoWidth": false,//自适应大小
        "bFilter": false,//是否显示查询框
        "bLengthChange": false,//不允许用户更改每页数据显示条数
        "sProcessing": "处理中...",//数据加载时显示文字
        "language": {
            "sLengthMenu": "每页显示 _MENU_ 条记录",
            "search": "搜索",
            "zeroRecords": "没有找到记录",
            "infoEmpty": "无记录",
            "sInfoFiltered": "(从 _MAX_ 条数据中检索)",
            "oPaginate": {
                "sFirst": "首页",
                "sPrevious": "上一页",
                "sNext": "下一页",
                "sLast": "末页"
            }
        },
        ajax: {
            url: '/Transport/GetSpecialLineByName',
            dataSrc: '',
            data: {
                "specialName": $("#SpecialName").val()
            }
        },
        columns: [
            { data: 'u_name' },
            { data: 'special_name' },
            { data: 'local_province_name' },
            { data: 'type' },
            { data: 'year' },
            { data: 'batch' },
            { data: 'average_score' },
            { data: 'min_score' }
        ]
    });
}

