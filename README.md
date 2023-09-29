# AwsZoneFileTransformation

## Description

Tool for transforming output file from command ```aws route53 list-resource-record-sets --hosted-zone-id <zoneID> > export.json``` to be compatible with import command ```aws route53 change-resource-record-sets --hosted-zone-id <zoneId> --change-batch file://<export.json>```

## Usage

```cli
./AwsZoneFileTransformation -i <inputfile.json> -o <outputfile.json> -a [CREATE|DELETE|UPSERT] -n true
```
