# Change Log
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/)
and this project adheres to [Semantic Versioning](http://semver.org/).

## [1.0.0] - 2017-03-xx
- Initial release

## [1.1.0] - 2017-07-03
- Added direct debit data, convert and validator models
- Added XML comments

## [1.1.1] - 2017-07-06
- Added build number to YAML for AppVeyor

## [1.1.2] - 2017-07-06
- Removed duplicate build-tag in assemble file version of the YAML

## [1.1.3] - 2017-07-07
- Altered UTC DateTime conversion to match format "2017-07-07T12:00:00Z"

## [1.1.4] - 2017-07-24
- Added missing properties for the direct debit payment response.
- Added missing properties for the payment response.

## [1.1.5] - 2017-07-24
- Altered build configurations for dotnet core project to be compatible with AppVeyor.

## [1.1.6] - 2017-08-21
- Add: Added missing Recurring property in credit card details
- Change: Return actual PSP error response instead of default static message
- Change: Moved URL properties to base request details

## [1.1.7] - 2017-08-21
- Restore output path to default for CM.Payments.Client.Core project

## [1.1.8] - 2017-08-24
- Added authentication URL in response details interface for generic use
 
## [1.1.9] - 2017-09-13
- Changed hardcoded client base uri to optional constructor parameter.

## [1.1.10] - 2017-10-13
- Removed charge validation rule to check the usage of WireTransfer.
- Removed charge validation rule to check currency.

## [1.1.11] - 2017-10-15
- Removed payment validation ISO check.

## [1.1.12] - 2017-11-15
- Added PaypalSaleID to PayPalDetailsResponse
- Added Email to WireTransferRequest.

## [1.1.13] - 2017-11-16
- Removed validation on SOFORT banknumber, bic and customer name.

## [1.1.14] - 2017-11-27
- Added Token property to CreditCardDetailsRequest.

## [1.1.15] - 2017-11-29
- Fixed issue with token being a bool instead of string.

## [1.1.16] - 2017-12-11
- Added RecurringID to CreditCardDetailsRequest.

## [1.1.17] - 2017-12-22
- Moved recurring_id and recurring boolean to paymentrequest instead of payment_details._

## [1.1.18] - 2017-01-12
- Added Tokenized payments properties for credit cards (CreditCardRedirectResponse).

## [1.1.19] - 2018-03-20
- Added CanWrite: false for custom PaymentsConverter, this will fallback to the default jsonConverter.