using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MedApp.Web.Helpers
{
    public static class BsGridHelper
    {
        public static MvcHtmlString BsGrid(this HtmlHelper helper, string actionName, string controllerName, Type type)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"
<script type='text/javascript'>
    $(function () {

        $('#demo_grid1').bs_grid({

            ajaxFetchDataURL: '/");
            sb.Append(controllerName + "/");
            sb.Append(actionName);
            sb.Append(@"',
            row_primary_key: '");
            sb.Append(type.GetProperties()[0].Name);
            sb.Append(@"',
            columns: [
                ");
            sb.Append(GetColumsText(type));

//@"{ field: 'Code', header: 'Code', visible: 'no' },
//                { field: 'FirstPaymentDue', header: 'First Payment Due' },
//                { field: 'firstname', header: 'Firstname' },
//                { field: 'email', header: 'Email', visible: 'no', 'sortable': 'no' },
//                { field: 'gender', header: 'Gender' },
//                { field: 'date_updated', header: 'Date updated' }
            sb.Append(@"],

            sorting: [");
            sb.Append(GetSortingColumsText(type));
                //{ sortingName: 'Code', field: 'Code', order: 'none' },
                //{ sortingName: 'First Payment Due', field: 'FirstPaymentDue', order: 'ascending' },
                //{ sortingName: 'Firstname', field: 'firstname', order: 'ascending' },
                //{ sortingName: 'Date updated', field: 'date_updated', order: 'none' }
            sb.Append(@"],

            filterOptions: {
                filters: [
//                    {
//                        filterName: 'First Payment Due', filterType : 'text', field: 'FirstPaymentDue', filterLabel: 'Last name',
//                        excluded_operators: ['in', 'not_in'],
//                        filter_interface: [
//                            {
//                                filter_element: 'input',
//                                filter_element_attributes: { 'type': 'text' }
//                            }
//                        ]
//                    },
//                    {
//                        filterName: 'Gender', 'filterType': 'number', 'numberType': 'integer', field: 'lk_genders_id', filterLabel: 'Gender',
//                        excluded_operators: ['equal', 'not_equal', 'less', 'less_or_equal', 'greater', 'greater_or_equal'],
//                        filter_interface: [
//                            {
//                                filter_element: 'input',
//                                filter_element_attributes: { type: 'checkbox' }
//                            }
//                        ],
//                        lookup_values: [
//                            { lk_option: 'Male', lk_value: '1' },
//                            { lk_option: 'Female', lk_value: '2', lk_selected: 'yes' }
//                        ]
//                    },
//                    {
//                        filterName: 'DateUpdated', 'filterType': 'date', field: 'date_updated', filterLabel: 'Datetime updated',
//                        excluded_operators: ['in', 'not_in'],
//                        filter_interface: [
//                            {
//                                filter_element: 'input',
//                                filter_element_attributes: {
//                                    type: 'text',
//                                    title: 'Set the date and time using format: dd/mm/yyyy hh:mm:ss'
//                                },
//                                filter_widget: 'datetimepicker',
//                                filter_widget_properties: {
//                                    dateFormat: 'dd/mm/yy',
//                                    timeFormat: 'HH:mm:ss',
//                                    changeMonth: true,
//                                    changeYear: true,
//                                    showSecond: true
//                                }
//                            }
//                        ],
//                        validate_dateformat: ['DD/MM/YYYY HH:mm:ss'],
//                        filter_value_conversion: {
//                            function_name: 'local_datetime_to_UTC_timestamp',
//                            args: [
//                                { 'filter_value': 'yes' },
//                                { 'value': 'DD/MM/YYYY HH:mm:ss' }
//                            ]
//                        }
//                    }
                ]
            }
        });

    });

</script>
");


            return MvcHtmlString.Create(sb.ToString());
        }

        private static string GetColumsText(Type type)
        {
            var colums = new List<string>();
            var properties = type.GetProperties();
            colums.Add(@"{field: '" +properties[0].Name+ @"', header: '" +properties[0].Name+ @"', visible: 'no'}");
            for (var i =1; i< properties.Length; i++)
            {
                colums.Add(@"{field: '" + properties[i].Name + @"', header: '" + (properties[i].GetCustomAttributesData().Count > 0 ? properties[i].GetCustomAttributesData()[0].ConstructorArguments[0].Value : properties[i].Name) + @"'}");
            }
            return string.Join(",", colums);

        }
        private static string GetSortingColumsText(Type type)
        {
            var colums = new List<string>();
            var properties = type.GetProperties();
            colums.Add(@"{sortingName: '"+properties[0].Name+@"', field: '"+properties[0].Name+@"', order: 'none'}");
            for (var i = 1; i < properties.Length; i++)
            {
                colums.Add(@"{sortingName: '" + (properties[i].GetCustomAttributesData().Count > 0 ? properties[i].GetCustomAttributesData()[0].ConstructorArguments[0].Value : properties[i].Name) + @"', field: '" + properties[i].Name + @"', order: 'ascending'}");
            }
            return string.Join(",", colums);

        }
    }
}