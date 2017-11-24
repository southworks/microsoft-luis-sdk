/*
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * Entity returned from LUIS.
 *
 */
class EntityModel {
  /**
   * Create a EntityModel.
   * @member {object} [additionalProperties] Unmatched properties from the
   * message are deserialized this collection
   * @member {string} entity
   * @member {string} type
   * @member {number} startIndex
   * @member {number} endIndex
   */
  constructor() {
  }

  /**
   * Defines the metadata of EntityModel
   *
   * @returns {object} metadata of EntityModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'EntityModel',
      type: {
        name: 'Composite',
        className: 'EntityModel',
        modelProperties: {
          additionalProperties: {
            required: false,
            type: {
              name: 'Dictionary',
              value: {
                  required: false,
                  serializedName: 'ObjectElementType',
                  type: {
                    name: 'Object'
                  }
              }
            }
          },
          entity: {
            required: true,
            serializedName: 'entity',
            type: {
              name: 'String'
            }
          },
          type: {
            required: true,
            serializedName: 'type',
            type: {
              name: 'String'
            }
          },
          startIndex: {
            required: true,
            serializedName: 'startIndex',
            type: {
              name: 'Number'
            }
          },
          endIndex: {
            required: true,
            serializedName: 'endIndex',
            type: {
              name: 'Number'
            }
          }
        }
      }
    };
  }
}

module.exports = EntityModel;